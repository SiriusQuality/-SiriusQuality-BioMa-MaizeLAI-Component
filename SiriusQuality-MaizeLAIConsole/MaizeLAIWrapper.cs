using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiriusQualityMaizeLAI;

namespace SiriusQuality_MaizeLAIConsole
{
    class MaizeLAIWrapper
    {

        #region Outputs

        public List<LeafState> getLeafStateList(){return GetStateListMaize(); }

        public List<LeafState> getLeafPreviousStateList(){return GetPreviousStateListMaize();}

        private List<LeafState> GetStateListMaize()
        {

            List<LeafState> list = new List<LeafState>();

            for (int ilayer = 0; ilayer < maizeLeafState1_.State.Count; ilayer++)
            {

                switch (maizeLeafState1_.State[ilayer])
                {
                    case 0:
                        list.Add(LeafState.Growing);
                        break;
                    case 1:
                        list.Add(LeafState.Mature);
                        break;
                }
            }


            return list;
        }

        private List<LeafState> GetPreviousStateListMaize()
        {

            List<LeafState> list = new List<LeafState>();

            for (int ilayer = 0; ilayer < maizeLeafState_.PreviousState.Count; ilayer++)
            {

                switch (maizeLeafState_.PreviousState[ilayer])
                {
                    case 0:
                        list.Add(LeafState.Growing);
                        break;
                    case 1:
                        list.Add(LeafState.Mature);
                        break;
                }
            }


            return list;
        }

        public List<int> getIsPrematurelyDyingList(){ return maizeLeafState_.isPrematurelyDying; }

        public double getIncDeltaAreaLimitSF(){ return maizeLaiState_.incDeltaAreaLimitSF; }

        public double getPotentialIncDeltaArea(){ return maizeLaiState_.potentialIncDeltaArea; }

        public double LER { get { return maizeLaiState_.LER; } }

        public double getWaterLimitedPotDeltaAI(int i)
        {
            if (i < maizeLaiState_.WaterLimitedPotDeltaAIList.Count)
                {
                    return maizeLaiState_.WaterLimitedPotDeltaAIList[i];
                }
                else
                {
                    return -1;
                }
        }

        #endregion

        #region Parameters

        //See "Documentation\Sirius Quality: BioMa MaizePotential LAI Component" document Table A2 for definitions
        //Values of genotypic parameters are given for hybrid B73_H. 

                internal double Nfinal = 16.0;//leaf, genotypic
                //Leaf Expansion Rate
                double LERa = 3.19;//mm/°Cd, genotypic
                double LERb = -1.17;//mm/°Cd/kPa, genotypic
                double LERc = 3.52;//mm/°Cd/MPa, genotypic
                double Beta = 0.68;//Dimensionless
                double Sigma = 0.46;//Dimensionless

                //Width
                double width6 = 41.0;//mm
                double betaW =  0.41;//Dimensionless
                double sigmaW = 0.69;//Dimensionless
                double radBase = 0.15;//MJ
                double SensiRad = 34;//mm/MJ
                
                //Width thermal time
                double lagStopWidthExpand = 39.0;//°Cd

                //Tip thermal time
                double atip = 51.0;//°Cd/leaf
                double btip = -49.0;//°Cd
                public double Dse = 33.0;//°Cd

                //Start elongation Thermal Time
                double k_bl = 0.708;//Dimensionless
                double Nlim = 6.0;//leaf

                //End elongation Thermal Time
                double Lagmax = 5.4;//°Cd/leaf
                double Nlast = 2.0;//leaf

                //ligulation thermal time
                double k_ll = 0.454;//dimensionless
                double alpha_tr = 0.52;//dimensionless
                double a_ll1 = 86.0;//°Cd/leaf
                double b_ll1 = 137.0;//°Cd

                //floral initiation Thermal Tima
                double  leafNoInitEmerg = 6.59;//leaf
                double LIR =  0.068;//initiation/°Cd
                double ttinitflo = 28.8777;//°Cd;
                
                //Leaf Area Index
                double plantDensity =  7.5;//plant/m²
                double SLNcri = 1.0;//g(N)/m²(leaf)
                
                
                
                

        #endregion

        #region Constructor

        public MaizeLAIWrapper()
        {
           maizeLAI_ = new SiriusQualityMaizeLAI.Strategies.MaizeLAI();
           maizeLaiState_ = new SiriusQualityMaizeLAI.MaizeLAIState();
           maizeLeafState_ = new SiriusQualityMaizeLAI.MaizeLeafState();
           maizeLeafState1_ = new SiriusQualityMaizeLAI.MaizeLeafState();
           loadParametersMaize();
            }

        public MaizeLAIWrapper(MaizeLAIWrapper toCopy)
        {

                maizeLaiState_ = (toCopy.maizeLaiState_ != null) ? new SiriusQualityMaizeLAI.MaizeLAIState(toCopy.maizeLaiState_) : null;
                maizeLeafState1_ = (toCopy.maizeLeafState1_ != null) ? new SiriusQualityMaizeLAI.MaizeLeafState(toCopy.maizeLeafState1_) : null;
                maizeLeafState_ = (toCopy.maizeLeafState_ != null) ? new SiriusQualityMaizeLAI.MaizeLeafState(toCopy.maizeLeafState_) : null;
                maizeLAI_ = (toCopy.maizeLAI_ != null) ? new SiriusQualityMaizeLAI.Strategies.MaizeLAI(toCopy.maizeLAI_) : null;
        }
        
        

        #endregion

        #region Estimate

        public void Estimate(double beforeUpdateLeafNumber, bool newLeafHasAppeared, double finalLeafNumber, double leafNumber,
            double FPAW, List<LeafLayer> All, double VPDairCanopy,
            double cumulTTPhenoMaize, double deltaTTPhenoMaize, double[] TCanopyHourly, double[] VPDeq, double radInterceptedMaize)
        {
                maizeLaiState_.newLeafHasAppeared = newLeafHasAppeared ? 1 : 0;
                maizeLaiState_.finalLeafNumber = finalLeafNumber;
                maizeLaiState_.leafNumber = leafNumber;
                maizeLaiState_.FPAW = FPAW;
                maizeLaiState_.cumulTTPHenoMaize = cumulTTPhenoMaize;
                maizeLaiState_.deltaTTPhenoMaize = deltaTTPhenoMaize;
                maizeLaiState_.VPDairCanopy = VPDairCanopy;
                maizeLaiState_.TCanopyHourly = TCanopyHourly;
                maizeLaiState_.VPDeq = VPDeq;
                maizeLaiState_.previousLeafNumber = beforeUpdateLeafNumber;
                maizeLaiState_.radIntercepted = radInterceptedMaize;

                FillIntputLayersMaize(All);

                maizeLAI_.Estimate(maizeLaiState_, maizeLeafState_, maizeLeafState1_,null);

                FillOutputLayersMaize(All);
        }


        public void UpdateAreas(double availN, List<LeafLayer> All)
        {
            maizeLaiState_.availableN = availN;

            maizeLaiState_.incDeltaAreaLimitSF = getIncDeltaAreaLimitSF();
            maizeLaiState_.potentialIncDeltaArea = getPotentialIncDeltaArea();
            for (int ilayer = 0; ilayer < All.Count; ilayer++) maizeLaiState_.WaterLimitedPotDeltaAIList[ilayer] = getWaterLimitedPotDeltaAI(ilayer);

            FillIntputLayersMaize(All);

            maizeLAI_.UpdateLeafArea(maizeLaiState_, maizeLeafState_, maizeLeafState1_, null);

            FillOutputLayersMaize(All, false);

        }


        #endregion

        #region Utilities

        private void FillIntputLayersMaize(List<LeafLayer> All)
        {

            for (int ilayer = 0; ilayer < All.Count; ilayer++)
            {

                switch (All[ilayer].State)
                {
                    case LeafState.Growing:
                        maizeLeafState_.State[ilayer] = 0;
                        break;
                    case LeafState.Mature:
                        maizeLeafState_.State[ilayer] = 1;
                        break;
                }
                maizeLeafState_.GAI[ilayer] = All[ilayer].GAI;
                maizeLeafState_.length[ilayer] = All[ilayer].length;
                maizeLeafState_.width[ilayer] = All[ilayer].width;
                maizeLeafState_.area[ilayer] = All[ilayer].area;
                maizeLeafState_.exposedArea[ilayer] = All[ilayer].exposedArea;

                maizeLeafState_.leafAge[ilayer] = All[ilayer].age;
                maizeLeafState_.cumIntRad[ilayer] = All[ilayer].cumIntRad;

            }
        }

        

        public void CreateLeafLayerLAIComponentMaize()
        {

            maizeLeafState_.State.Add(0);
            maizeLeafState_.liguleTT.Add(0.0);
            maizeLeafState_.fullyExpTT.Add(0.0);
            maizeLeafState_.GAI.Add(0.0);
            maizeLeafState_.length.Add(0.0);
            maizeLeafState_.width.Add(0.0);
            maizeLeafState_.fracPopn.Add(0.0);
            maizeLeafState_.startExpTT.Add(0.0);
            maizeLeafState_.baseWidth.Add(0.0);
            maizeLeafState_.coefLER.Add(0.0);
            maizeLeafState_.tipTT.Add(0.0);
            maizeLeafState_.exposedArea.Add(0.0);
            maizeLeafState_.PreviousState.Add(0);
            maizeLeafState_.isPrematurelyDying.Add(0);
            maizeLeafState_.leafAge.Add(0.0);
            maizeLeafState_.cumIntRad.Add(0.0);
            maizeLeafState_.initialisationTT.Add(0.0);
            maizeLeafState_.stopEnlargeTT.Add(0.0);
            maizeLeafState_.startEnlargeTT.Add(0.0);

            maizeLeafState1_.width.Add(0.0);
            maizeLeafState1_.length.Add(0.0);
            maizeLeafState1_.State.Add(0);
            maizeLeafState1_.exposedArea.Add(0.0);
            maizeLeafState1_.leafAge.Add(0.0);
            maizeLeafState1_.cumIntRad.Add(0.0);

            maizeLeafState1_.MaxAI.Add(0.0);
            maizeLeafState1_.deltaAI.Add(0.0);
            maizeLeafState1_.LaminaAI.Add(0.0);
            maizeLeafState1_.area.Add(0.0);

            maizeLeafState_.MaxAI.Add(0.0);
            maizeLeafState_.deltaAI.Add(0.0);
            maizeLeafState_.LaminaAI.Add(0.0);
            maizeLeafState_.area.Add(0.0);


        }

        private void FillOutputLayersMaize(List<LeafLayer> All, bool isEstimate=true)
        {
            for (int ilayer = 0; ilayer < maizeLeafState_.State.Count; ilayer++)
            {
                if (isEstimate)
                {
                    switch (maizeLeafState_.State[ilayer])
                    {
                        case 0:
                            All[ilayer].setState(LeafState.Growing);
                            break;
                        case 1:
                            All[ilayer].setState(LeafState.Mature);
                            break;
                    }

                    All[ilayer].length = maizeLeafState1_.length[ilayer];
                    All[ilayer].width = maizeLeafState_.width[ilayer];
                    All[ilayer].area = maizeLeafState1_.area[ilayer];
                    All[ilayer].exposedArea = maizeLeafState1_.exposedArea[ilayer];

                    All[ilayer].age = maizeLeafState1_.leafAge[ilayer];
                    All[ilayer].cumIntRad = maizeLeafState1_.cumIntRad[ilayer];
                }
                else
                {
                    All[ilayer].MaxAI = maizeLeafState1_.MaxAI[ilayer];
                    All[ilayer].DeltaAI = maizeLeafState_.deltaAI[ilayer];
                    All[ilayer].laminaAI=maizeLeafState_.LaminaAI[ilayer];
                }

            }

        }


        private void loadParametersMaize()
        {
            maizeLAI_.Nfinal = Nfinal;
            maizeLAI_.width6 = width6;
            maizeLAI_.betaW = betaW;
            maizeLAI_.sigmaW = sigmaW;
            maizeLAI_.Lagmax = Lagmax;
            maizeLAI_.Nlast = Nlast;
            maizeLAI_.leafNoInitEmerg = leafNoInitEmerg;
            maizeLAI_.LIR = LIR;
            maizeLAI_.LERa = LERa;
            maizeLAI_.LERb = LERb;
            maizeLAI_.LERc = LERc;
            maizeLAI_.Beta = Beta;
            maizeLAI_.Sigma = Sigma;
            maizeLAI_.b_ll1 = b_ll1;
            maizeLAI_.k_ll = k_ll;
            maizeLAI_.a_ll1 = a_ll1;
            maizeLAI_.Dse = Dse;
            maizeLAI_.alpha_tr = alpha_tr;
            maizeLAI_.atip = atip;
            maizeLAI_.k_bl = k_bl;
            maizeLAI_.Nlim = Nlim;
            maizeLAI_.btip = btip;
            maizeLAI_.lagStopWidthExpand = lagStopWidthExpand;
            maizeLAI_.plantDensity = plantDensity;
            maizeLAI_.SensiRad = SensiRad;
            maizeLAI_.radBase = radBase;
            maizeLAI_.SLNcri = SLNcri;
            maizeLAI_.ttinitflo=ttinitflo;

        }

        #endregion

        #region Instantiation

        private SiriusQualityMaizeLAI.MaizeLAIState maizeLaiState_;
        private SiriusQualityMaizeLAI.Strategies.MaizeLAI maizeLAI_;
        private SiriusQualityMaizeLAI.MaizeLeafState maizeLeafState_;
        private SiriusQualityMaizeLAI.MaizeLeafState maizeLeafState1_;

        #endregion
    }
}
