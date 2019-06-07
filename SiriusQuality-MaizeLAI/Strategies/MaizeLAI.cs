

 //Author:Loic Manceau loic.manceau@inra.fr
 //Institution:INRA
 //Author of revision: 
 //Date first release:6/7/2019
 //Date of revision:

using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using CRA.ModelLayer.MetadataTypes;
using CRA.ModelLayer.Core;
using CRA.ModelLayer.Strategy;
using System.Reflection;
using VarInfo=CRA.ModelLayer.Core.VarInfo;
using Preconditions=CRA.ModelLayer.Core.Preconditions;


using SiriusQualityMaizeLAI;
using CRA.AgroManagement;


//To make this project compile please add the reference to assembly: SiriusQuality-MaizeLAI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
//To make this project compile please add the reference to assembly: CRA.ModelLayer, Version=1.0.5212.29139, Culture=neutral, PublicKeyToken=null
//To make this project compile please add the reference to assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
//To make this project compile please add the reference to assembly: CRA.AgroManagement2014, Version=0.8.0.0, Culture=neutral, PublicKeyToken=null
//To make this project compile please add the reference to assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
//To make this project compile please add the reference to assembly: System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;

namespace SiriusQualityMaizeLAI.Strategies
{

	/// <summary>
	///Class MaizeLAI
    /// Composite Class
    /// </summary>
	public class MaizeLAI : IStrategySiriusQualityMaizeLAI
	{

	#region Constructor

			public MaizeLAI()
			{
				
				ModellingOptions mo0_0 = new ModellingOptions();
				//Parameters
				List<VarInfo> _parameters0_0 = new List<VarInfo>();
				VarInfo v1 = new CompositeStrategyVarInfo(_calcbasewidth,"Nfinal");
				 _parameters0_0.Add(v1);
				VarInfo v2 = new CompositeStrategyVarInfo(_calcbasewidth,"width6");
				 _parameters0_0.Add(v2);
				VarInfo v3 = new CompositeStrategyVarInfo(_calcbasewidth,"betaW");
				 _parameters0_0.Add(v3);
				VarInfo v4 = new CompositeStrategyVarInfo(_calcbasewidth,"sigmaW");
				 _parameters0_0.Add(v4);
				VarInfo v5 = new CompositeStrategyVarInfo(_calcfullyexptt,"Nfinal");
				 _parameters0_0.Add(v5);
				VarInfo v6 = new CompositeStrategyVarInfo(_calcfullyexptt,"Lagmax");
				 _parameters0_0.Add(v6);
				VarInfo v7 = new CompositeStrategyVarInfo(_calcfullyexptt,"Nlast");
				 _parameters0_0.Add(v7);
				VarInfo v8 = new CompositeStrategyVarInfo(_calcinittt,"leafNoInitEmerg");
				 _parameters0_0.Add(v8);
				VarInfo v9 = new CompositeStrategyVarInfo(_calcinittt,"LIR");
				 _parameters0_0.Add(v9);
				VarInfo v10 = new CompositeStrategyVarInfo(_calcinittt,"ttinitflo");
				 _parameters0_0.Add(v10);
				VarInfo v11 = new CompositeStrategyVarInfo(_calcler,"LERa");
				 _parameters0_0.Add(v11);
				VarInfo v12 = new CompositeStrategyVarInfo(_calcler,"LERb");
				 _parameters0_0.Add(v12);
				VarInfo v13 = new CompositeStrategyVarInfo(_calcler,"LERc");
				 _parameters0_0.Add(v13);
				VarInfo v14 = new CompositeStrategyVarInfo(_calclercoeff,"Nfinal");
				 _parameters0_0.Add(v14);
				VarInfo v15 = new CompositeStrategyVarInfo(_calclercoeff,"Beta");
				 _parameters0_0.Add(v15);
				VarInfo v16 = new CompositeStrategyVarInfo(_calclercoeff,"Sigma");
				 _parameters0_0.Add(v16);
				VarInfo v17 = new CompositeStrategyVarInfo(_calcligulett,"b_ll1");
				 _parameters0_0.Add(v17);
				VarInfo v18 = new CompositeStrategyVarInfo(_calcligulett,"k_ll");
				 _parameters0_0.Add(v18);
				VarInfo v19 = new CompositeStrategyVarInfo(_calcligulett,"a_ll1");
				 _parameters0_0.Add(v19);
				VarInfo v20 = new CompositeStrategyVarInfo(_calcligulett,"Nfinal");
				 _parameters0_0.Add(v20);
				VarInfo v21 = new CompositeStrategyVarInfo(_calcligulett,"Dse");
				 _parameters0_0.Add(v21);
				VarInfo v22 = new CompositeStrategyVarInfo(_calcligulett,"alpha_tr");
				 _parameters0_0.Add(v22);
				VarInfo v23 = new CompositeStrategyVarInfo(_calcstartexptt,"atip");
				 _parameters0_0.Add(v23);
				VarInfo v24 = new CompositeStrategyVarInfo(_calcstartexptt,"k_bl");
				 _parameters0_0.Add(v24);
				VarInfo v25 = new CompositeStrategyVarInfo(_calcstartexptt,"Nlim");
				 _parameters0_0.Add(v25);
				VarInfo v26 = new CompositeStrategyVarInfo(_calcstartexptt,"btip");
				 _parameters0_0.Add(v26);
				VarInfo v27 = new CompositeStrategyVarInfo(_calcstartexptt,"Dse");
				 _parameters0_0.Add(v27);
				VarInfo v28 = new CompositeStrategyVarInfo(_calcstopenlargett,"lagStopWidthExpand");
				 _parameters0_0.Add(v28);
				VarInfo v29 = new CompositeStrategyVarInfo(_calctiptt,"Dse");
				 _parameters0_0.Add(v29);
				VarInfo v30 = new CompositeStrategyVarInfo(_calctiptt,"atip");
				 _parameters0_0.Add(v30);
				VarInfo v31 = new CompositeStrategyVarInfo(_calctiptt,"btip");
				 _parameters0_0.Add(v31);
				VarInfo v32 = new CompositeStrategyVarInfo(_deltalaimaize,"plantDensity");
				 _parameters0_0.Add(v32);
				VarInfo v33 = new CompositeStrategyVarInfo(_deltalaimaize,"SensiRad");
				 _parameters0_0.Add(v33);
				VarInfo v34 = new CompositeStrategyVarInfo(_deltalaimaize,"radBase");
				 _parameters0_0.Add(v34);
				VarInfo v35 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"LowerFPAWexp");
				 _parameters0_0.Add(v35);
				VarInfo v36 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"UpperFPAWexp");
				 _parameters0_0.Add(v36);
				VarInfo v37 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"MaxDSF");
				 _parameters0_0.Add(v37);
				VarInfo v38 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"LowerFPAWsen");
				 _parameters0_0.Add(v38);
				VarInfo v39 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"UpperFPAWsen");
				 _parameters0_0.Add(v39);
				VarInfo v40 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"UpperVPD");
				 _parameters0_0.Add(v40);
				VarInfo v41 = new CompositeStrategyVarInfo(_leafexpansiondroughtfactor,"LowerVPD");
				 _parameters0_0.Add(v41);
				VarInfo v42 = new CompositeStrategyVarInfo(_updateleafarea,"SLNcri");
				 _parameters0_0.Add(v42);
				mo0_0.Parameters=_parameters0_0;
				//Inputs
				List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
				mo0_0.Inputs=_inputs0_0;
				//Outputs
				List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
				mo0_0.Outputs=_outputs0_0;
				//Associated strategies
				List<string> lAssStrat0_0 = new List<string>();
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcBaseWidth).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcFullyExpTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcFracPopn).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcInitTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcLER).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcLERCoeff).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcLiguleTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcStartExpTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcStartEnlargeTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.calcTipTT).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor).FullName);
				lAssStrat0_0.Add(typeof(SiriusQualityMaizeLAI.Strategies.UpdateLeafArea).FullName);
				mo0_0.AssociatedStrategies = lAssStrat0_0;
				//Adding the modeling options to the modeling options manager

				//Creating the modeling options manager of the strategy
				_modellingOptionsManager = new ModellingOptionsManager(mo0_0);
			
				SetStaticParametersVarInfoDefinitions();
				SetPublisherData();
					
			}

	#endregion

	#region Implementation of IAnnotatable

			/// <summary>
			/// Description of the model
			/// </summary>
			public string Description
			{
				get { return "Composite Class"; }
			}
			
			/// <summary>
			/// URL to access the description of the model
			/// </summary>
			public string URL
			{
				get { return "http://biomamodelling.org"; }
			}
		

	#endregion
	
	#region Implementation of IStrategy

			/// <summary>
			/// Domain of the model.
			/// </summary>
			public string Domain
			{
				get {  return "Crop"; }
			}

			/// <summary>
			/// Type of the model.
			/// </summary>
			public string ModelType
			{
				get { return ""; }
			}

			/// <summary>
			/// Declare if the strategy is a ContextStrategy, that is, it contains logic to select a strategy at run time. 
			/// </summary>
			public bool IsContext
			{
					get { return  false; }
			}

			/// <summary>
			/// Timestep to be used with this strategy
			/// </summary>
			public IList<int> TimeStep
			{
				get
				{
					IList<int> ts = new List<int>();
					
					return ts;
				}
			}
	
	
	#region Publisher Data

			private PublisherData _pd;
			private  void SetPublisherData()
			{
					// Set publishers' data
					
				_pd = new CRA.ModelLayer.MetadataTypes.PublisherData();
				_pd.Add("Creator", "loic.manceau@inra.fr");
				_pd.Add("Date", "6/7/2019");
				_pd.Add("Publisher", "INRA");
			}

			public PublisherData PublisherData
			{
				get { return _pd; }
			}

	#endregion

	#region ModellingOptionsManager

			private ModellingOptionsManager _modellingOptionsManager;
			
			public ModellingOptionsManager ModellingOptionsManager
			{
				get { return _modellingOptionsManager; }            
			}

	#endregion

			/// <summary>
			/// Return the types of the domain classes used by the strategy
			/// </summary>
			/// <returns></returns>
			public IEnumerable<Type> GetStrategyDomainClassesTypes()
			{
				return new List<Type>() {  typeof(SiriusQualityMaizeLAI.MaizeLAIState),typeof(SiriusQualityMaizeLAI.MaizeLeafState),typeof(SiriusQualityMaizeLAI.MaizeLeafState),typeof(CRA.AgroManagement.ActEvents) };
			}

	#endregion

    #region Instances of the parameters
			
			// Getter and setters for the value of the parameters of the strategy. The actual parameters are stored into the ModelingOptionsManager of the strategy.

			

			// Getter and setters for the value of the parameters of a composite strategy
			
			public Double Nfinal
			{ 
				get {
						return _calcbasewidth.Nfinal ;
				}
				set {
						_calcbasewidth.Nfinal=value;
						_calcfullyexptt.Nfinal=value;
						_calclercoeff.Nfinal=value;
						_calcligulett.Nfinal=value;
				}
			}
			public Double width6
			{ 
				get {
						return _calcbasewidth.width6 ;
				}
				set {
						_calcbasewidth.width6=value;
				}
			}
			public Double betaW
			{ 
				get {
						return _calcbasewidth.betaW ;
				}
				set {
						_calcbasewidth.betaW=value;
				}
			}
			public Double sigmaW
			{ 
				get {
						return _calcbasewidth.sigmaW ;
				}
				set {
						_calcbasewidth.sigmaW=value;
				}
			}
			public Double Lagmax
			{ 
				get {
						return _calcfullyexptt.Lagmax ;
				}
				set {
						_calcfullyexptt.Lagmax=value;
				}
			}
			public Double Nlast
			{ 
				get {
						return _calcfullyexptt.Nlast ;
				}
				set {
						_calcfullyexptt.Nlast=value;
				}
			}
			public Double leafNoInitEmerg
			{ 
				get {
						return _calcinittt.leafNoInitEmerg ;
				}
				set {
						_calcinittt.leafNoInitEmerg=value;
				}
			}
			public Double LIR
			{ 
				get {
						return _calcinittt.LIR ;
				}
				set {
						_calcinittt.LIR=value;
				}
			}
			public Double ttinitflo
			{ 
				get {
						return _calcinittt.ttinitflo ;
				}
				set {
						_calcinittt.ttinitflo=value;
				}
			}
			public Double LERa
			{ 
				get {
						return _calcler.LERa ;
				}
				set {
						_calcler.LERa=value;
				}
			}
			public Double LERb
			{ 
				get {
						return _calcler.LERb ;
				}
				set {
						_calcler.LERb=value;
				}
			}
			public Double LERc
			{ 
				get {
						return _calcler.LERc ;
				}
				set {
						_calcler.LERc=value;
				}
			}
			public Double Beta
			{ 
				get {
						return _calclercoeff.Beta ;
				}
				set {
						_calclercoeff.Beta=value;
				}
			}
			public Double Sigma
			{ 
				get {
						return _calclercoeff.Sigma ;
				}
				set {
						_calclercoeff.Sigma=value;
				}
			}
			public Double b_ll1
			{ 
				get {
						return _calcligulett.b_ll1 ;
				}
				set {
						_calcligulett.b_ll1=value;
				}
			}
			public Double k_ll
			{ 
				get {
						return _calcligulett.k_ll ;
				}
				set {
						_calcligulett.k_ll=value;
				}
			}
			public Double a_ll1
			{ 
				get {
						return _calcligulett.a_ll1 ;
				}
				set {
						_calcligulett.a_ll1=value;
				}
			}
			public Double Dse
			{ 
				get {
						return _calcligulett.Dse ;
				}
				set {
						_calcligulett.Dse=value;
						_calcstartexptt.Dse=value;
						_calctiptt.Dse=value;
				}
			}
			public Double alpha_tr
			{ 
				get {
						return _calcligulett.alpha_tr ;
				}
				set {
						_calcligulett.alpha_tr=value;
				}
			}
			public Double atip
			{ 
				get {
						return _calcstartexptt.atip ;
				}
				set {
						_calcstartexptt.atip=value;
						_calctiptt.atip=value;
				}
			}
			public Double k_bl
			{ 
				get {
						return _calcstartexptt.k_bl ;
				}
				set {
						_calcstartexptt.k_bl=value;
				}
			}
			public Double Nlim
			{ 
				get {
						return _calcstartexptt.Nlim ;
				}
				set {
						_calcstartexptt.Nlim=value;
				}
			}
			public Double btip
			{ 
				get {
						return _calcstartexptt.btip ;
				}
				set {
						_calcstartexptt.btip=value;
						_calctiptt.btip=value;
				}
			}
			public Double lagStopWidthExpand
			{ 
				get {
						return _calcstopenlargett.lagStopWidthExpand ;
				}
				set {
						_calcstopenlargett.lagStopWidthExpand=value;
				}
			}
			public Double plantDensity
			{ 
				get {
						return _deltalaimaize.plantDensity ;
				}
				set {
						_deltalaimaize.plantDensity=value;
				}
			}
			public Double SensiRad
			{ 
				get {
						return _deltalaimaize.SensiRad ;
				}
				set {
						_deltalaimaize.SensiRad=value;
				}
			}
			public Double radBase
			{ 
				get {
						return _deltalaimaize.radBase ;
				}
				set {
						_deltalaimaize.radBase=value;
				}
			}
			public Double LowerFPAWexp
			{ 
				get {
						return _leafexpansiondroughtfactor.LowerFPAWexp ;
				}
				set {
						_leafexpansiondroughtfactor.LowerFPAWexp=value;
				}
			}
			public Double UpperFPAWexp
			{ 
				get {
						return _leafexpansiondroughtfactor.UpperFPAWexp ;
				}
				set {
						_leafexpansiondroughtfactor.UpperFPAWexp=value;
				}
			}
			public Double MaxDSF
			{ 
				get {
						return _leafexpansiondroughtfactor.MaxDSF ;
				}
				set {
						_leafexpansiondroughtfactor.MaxDSF=value;
				}
			}
			public Double LowerFPAWsen
			{ 
				get {
						return _leafexpansiondroughtfactor.LowerFPAWsen ;
				}
				set {
						_leafexpansiondroughtfactor.LowerFPAWsen=value;
				}
			}
			public Double UpperFPAWsen
			{ 
				get {
						return _leafexpansiondroughtfactor.UpperFPAWsen ;
				}
				set {
						_leafexpansiondroughtfactor.UpperFPAWsen=value;
				}
			}
			public Double UpperVPD
			{ 
				get {
						return _leafexpansiondroughtfactor.UpperVPD ;
				}
				set {
						_leafexpansiondroughtfactor.UpperVPD=value;
				}
			}
			public Double LowerVPD
			{ 
				get {
						return _leafexpansiondroughtfactor.LowerVPD ;
				}
				set {
						_leafexpansiondroughtfactor.LowerVPD=value;
				}
			}
			public Double SLNcri
			{ 
				get {
						return _updateleafarea.SLNcri ;
				}
				set {
						_updateleafarea.SLNcri=value;
				}
			}

	#endregion		

	
	#region Parameters initialization method
			
            /// <summary>
            /// Set parameter(s) current values to the default value
            /// </summary>
            public void SetParametersDefaultValue()
            {
				_modellingOptionsManager.SetParametersDefaultValue();
				
					_calcbasewidth.SetParametersDefaultValue();
					_calcfullyexptt.SetParametersDefaultValue();
					_calcfracpopn.SetParametersDefaultValue();
					_calcinittt.SetParametersDefaultValue();
					_calcler.SetParametersDefaultValue();
					_calclercoeff.SetParametersDefaultValue();
					_calcligulett.SetParametersDefaultValue();
					_calcstartexptt.SetParametersDefaultValue();
					_calcstartenlargett.SetParametersDefaultValue();
					_calcstopenlargett.SetParametersDefaultValue();
					_calctiptt.SetParametersDefaultValue();
					_deltalaimaize.SetParametersDefaultValue();
					_leafexpansiondroughtfactor.SetParametersDefaultValue();
					_updateleafarea.SetParametersDefaultValue(); 

					//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section5
					//Code written below will not be overwritten by a future code generation

					//Custom initialization of the parameter. E.g. initialization of the array dimensions of array parameters

					//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
					//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section5 
            }

	#endregion		

	#region Static parameters VarInfo definition

			// Define the properties of the static VarInfo of the parameters
			private static void SetStaticParametersVarInfoDefinitions()
			{                                
                
       
			}

			//Parameters static VarInfo list 
								
			
			//Parameters static VarInfo list of the composite class
			
				/// <summary> 
				///Nfinal VarInfo definition
				/// </summary>
				public static VarInfo NfinalVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcBaseWidth.NfinalVarInfo; }
				}
				/// <summary> 
				///width6 VarInfo definition
				/// </summary>
				public static VarInfo width6VarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcBaseWidth.width6VarInfo; }
				}
				/// <summary> 
				///betaW VarInfo definition
				/// </summary>
				public static VarInfo betaWVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcBaseWidth.betaWVarInfo; }
				}
				/// <summary> 
				///sigmaW VarInfo definition
				/// </summary>
				public static VarInfo sigmaWVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcBaseWidth.sigmaWVarInfo; }
				}
				/// <summary> 
				///Lagmax VarInfo definition
				/// </summary>
				public static VarInfo LagmaxVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcFullyExpTT.LagmaxVarInfo; }
				}
				/// <summary> 
				///Nlast VarInfo definition
				/// </summary>
				public static VarInfo NlastVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcFullyExpTT.NlastVarInfo; }
				}
				/// <summary> 
				///leafNoInitEmerg VarInfo definition
				/// </summary>
				public static VarInfo leafNoInitEmergVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcInitTT.leafNoInitEmergVarInfo; }
				}
				/// <summary> 
				///LIR VarInfo definition
				/// </summary>
				public static VarInfo LIRVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcInitTT.LIRVarInfo; }
				}
				/// <summary> 
				///ttinitflo VarInfo definition
				/// </summary>
				public static VarInfo ttinitfloVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcInitTT.ttinitfloVarInfo; }
				}
				/// <summary> 
				///LERa VarInfo definition
				/// </summary>
				public static VarInfo LERaVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLER.LERaVarInfo; }
				}
				/// <summary> 
				///LERb VarInfo definition
				/// </summary>
				public static VarInfo LERbVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLER.LERbVarInfo; }
				}
				/// <summary> 
				///LERc VarInfo definition
				/// </summary>
				public static VarInfo LERcVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLER.LERcVarInfo; }
				}
				/// <summary> 
				///Beta VarInfo definition
				/// </summary>
				public static VarInfo BetaVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLERCoeff.BetaVarInfo; }
				}
				/// <summary> 
				///Sigma VarInfo definition
				/// </summary>
				public static VarInfo SigmaVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLERCoeff.SigmaVarInfo; }
				}
				/// <summary> 
				///b_ll1 VarInfo definition
				/// </summary>
				public static VarInfo b_ll1VarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLiguleTT.b_ll1VarInfo; }
				}
				/// <summary> 
				///k_ll VarInfo definition
				/// </summary>
				public static VarInfo k_llVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLiguleTT.k_llVarInfo; }
				}
				/// <summary> 
				///a_ll1 VarInfo definition
				/// </summary>
				public static VarInfo a_ll1VarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLiguleTT.a_ll1VarInfo; }
				}
				/// <summary> 
				///Dse VarInfo definition
				/// </summary>
				public static VarInfo DseVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLiguleTT.DseVarInfo; }
				}
				/// <summary> 
				///alpha_tr VarInfo definition
				/// </summary>
				public static VarInfo alpha_trVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcLiguleTT.alpha_trVarInfo; }
				}
				/// <summary> 
				///atip VarInfo definition
				/// </summary>
				public static VarInfo atipVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcStartExpTT.atipVarInfo; }
				}
				/// <summary> 
				///k_bl VarInfo definition
				/// </summary>
				public static VarInfo k_blVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcStartExpTT.k_blVarInfo; }
				}
				/// <summary> 
				///Nlim VarInfo definition
				/// </summary>
				public static VarInfo NlimVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcStartExpTT.NlimVarInfo; }
				}
				/// <summary> 
				///btip VarInfo definition
				/// </summary>
				public static VarInfo btipVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcStartExpTT.btipVarInfo; }
				}
				/// <summary> 
				///lagStopWidthExpand VarInfo definition
				/// </summary>
				public static VarInfo lagStopWidthExpandVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT.lagStopWidthExpandVarInfo; }
				}
				/// <summary> 
				///plantDensity VarInfo definition
				/// </summary>
				public static VarInfo plantDensityVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize.plantDensityVarInfo; }
				}
				/// <summary> 
				///SensiRad VarInfo definition
				/// </summary>
				public static VarInfo SensiRadVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize.SensiRadVarInfo; }
				}
				/// <summary> 
				///radBase VarInfo definition
				/// </summary>
				public static VarInfo radBaseVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize.radBaseVarInfo; }
				}
				/// <summary> 
				///LowerFPAWexp VarInfo definition
				/// </summary>
				public static VarInfo LowerFPAWexpVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.LowerFPAWexpVarInfo; }
				}
				/// <summary> 
				///UpperFPAWexp VarInfo definition
				/// </summary>
				public static VarInfo UpperFPAWexpVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.UpperFPAWexpVarInfo; }
				}
				/// <summary> 
				///MaxDSF VarInfo definition
				/// </summary>
				public static VarInfo MaxDSFVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.MaxDSFVarInfo; }
				}
				/// <summary> 
				///LowerFPAWsen VarInfo definition
				/// </summary>
				public static VarInfo LowerFPAWsenVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.LowerFPAWsenVarInfo; }
				}
				/// <summary> 
				///UpperFPAWsen VarInfo definition
				/// </summary>
				public static VarInfo UpperFPAWsenVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.UpperFPAWsenVarInfo; }
				}
				/// <summary> 
				///UpperVPD VarInfo definition
				/// </summary>
				public static VarInfo UpperVPDVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.UpperVPDVarInfo; }
				}
				/// <summary> 
				///LowerVPD VarInfo definition
				/// </summary>
				public static VarInfo LowerVPDVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor.LowerVPDVarInfo; }
				}
				/// <summary> 
				///SLNcri VarInfo definition
				/// </summary>
				public static VarInfo SLNcriVarInfo
				{
					get { return SiriusQualityMaizeLAI.Strategies.UpdateLeafArea.SLNcriVarInfo; }
				}			

	#endregion
	
	#region pre/post conditions management		

		    /// <summary>
			/// Test to verify the postconditions
			/// </summary>
			public string TestPostConditions(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1, string callID)
			{
				try
				{
					//Set current values of the outputs to the static VarInfo representing the output properties of the domain classes				
					
					
					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();            
					
					

					
					string ret = "";
					 ret += _calcbasewidth.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcBaseWidth");
					 ret += _calcfullyexptt.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcFullyExpTT");
					 ret += _calcfracpopn.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcFracPopn");
					 ret += _calcinittt.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcInitTT");
					 ret += _calcler.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLER");
					 ret += _calclercoeff.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLERCoeff");
					 ret += _calcligulett.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLiguleTT");
					 ret += _calcstartexptt.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStartExpTT");
					 ret += _calcstartenlargett.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStartEnlargeTT");
					 ret += _calcstopenlargett.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT");
					 ret += _calctiptt.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcTipTT");
					 ret += _deltalaimaize.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize");
					 ret += _leafexpansiondroughtfactor.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor");
					 ret += _updateleafarea.TestPostConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.UpdateLeafArea");
					if (ret != "") { pre.TestsOut(ret, true, "   postconditions tests of associated classes"); }

					//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section4
					//Code written below will not be overwritten by a future code generation

        

					//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
					//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section4 

					//Get the evaluation of postconditions
					string postConditionsResult =pre.VerifyPostconditions(prc, callID);
					//if we have errors, send it to the configured output 
					if(!string.IsNullOrEmpty(postConditionsResult)) { pre.TestsOut(postConditionsResult, true, "PostConditions errors in component SiriusQualityMaizeLAI.Strategies, strategy " + this.GetType().Name ); }
					return postConditionsResult;
				}
				catch (Exception exception)
				{
					//Uncomment the next line to use the trace
					//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1001,	"Strategy: " + this.GetType().Name + " - Unhandled exception running post-conditions");

					string msg = "Component SiriusQualityMaizeLAI.Strategies, " + this.GetType().Name + ": Unhandled exception running post-condition test. ";
					throw new Exception(msg, exception);
				}
			}

			/// <summary>
			/// Test to verify the preconditions
			/// </summary>
			public string TestPreConditions(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1, string callID)
			{
				try
				{
					//Set current values of the inputs to the static VarInfo representing the input properties of the domain classes				
					

					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();
            
					

					
					string ret = "";
					 ret += _calcbasewidth.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcBaseWidth");
					 ret += _calcfullyexptt.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcFullyExpTT");
					 ret += _calcfracpopn.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcFracPopn");
					 ret += _calcinittt.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcInitTT");
					 ret += _calcler.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLER");
					 ret += _calclercoeff.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLERCoeff");
					 ret += _calcligulett.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcLiguleTT");
					 ret += _calcstartexptt.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStartExpTT");
					 ret += _calcstartenlargett.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStartEnlargeTT");
					 ret += _calcstopenlargett.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT");
					 ret += _calctiptt.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.calcTipTT");
					 ret += _deltalaimaize.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize");
					 ret += _leafexpansiondroughtfactor.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor");
					 ret += _updateleafarea.TestPreConditions(maizelaistate,maizeleafstate,maizeleafstate1, "strategy SiriusQualityMaizeLAI.Strategies.UpdateLeafArea");
					if (ret != "") { pre.TestsOut(ret, true, "   preconditions tests of associated classes"); }

					//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section3
					//Code written below will not be overwritten by a future code generation

        

					//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
					//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section3 
								
					//Get the evaluation of preconditions;					
					string preConditionsResult =pre.VerifyPreconditions(prc, callID);
					//if we have errors, send it to the configured output 
					if(!string.IsNullOrEmpty(preConditionsResult)) { pre.TestsOut(preConditionsResult, true, "PreConditions errors in component SiriusQualityMaizeLAI.Strategies, strategy " + this.GetType().Name ); }
					return preConditionsResult;
				}
				catch (Exception exception)
				{
					//Uncomment the next line to use the trace
					//	TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1002,"Strategy: " + this.GetType().Name + " - Unhandled exception running pre-conditions");

					string msg = "Component SiriusQualityMaizeLAI.Strategies, " + this.GetType().Name + ": Unhandled exception running pre-condition test. ";
					throw new Exception(msg, exception);
				}
			}

		
	#endregion
		


	#region Model

		 	/// <summary>
			/// Run the strategy to calculate the outputs. In case of error during the execution, the preconditions tests are executed.
			/// </summary>
			public void Estimate(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1,CRA.AgroManagement.ActEvents actevents)
			{
				try
				{
					CalculateModel(maizelaistate,maizeleafstate,maizeleafstate1,actevents);

					//Uncomment the next line to use the trace
					//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Verbose, 1005,"Strategy: " + this.GetType().Name + " - Model executed");
				}
				catch (Exception exception)
				{
					//Uncomment the next line to use the trace
					//TraceStrategies.TraceEvent(System.Diagnostics.TraceEventType.Error, 1003,		"Strategy: " + this.GetType().Name + " - Unhandled exception running model");

					string msg = "Error in component SiriusQualityMaizeLAI.Strategies, strategy: " + this.GetType().Name + ": Unhandled exception running model. "+exception.GetType().FullName+" - "+exception.Message;				
					throw new Exception(msg, exception);
				}
			}

		

			private void CalculateModel(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1,CRA.AgroManagement.ActEvents actevents)
			{				
				
					EstimateOfAssociatedClasses(maizelaistate,maizeleafstate,maizeleafstate1,actevents);

				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section1
				//Code written below will not be overwritten by a future code generation


				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section1 
			}

				
			#region Composite class: associations

			//Declaration of the associated strategies
			SiriusQualityMaizeLAI.Strategies.calcBaseWidth _calcbasewidth = new SiriusQualityMaizeLAI.Strategies.calcBaseWidth();
			SiriusQualityMaizeLAI.Strategies.calcFullyExpTT _calcfullyexptt = new SiriusQualityMaizeLAI.Strategies.calcFullyExpTT();
			SiriusQualityMaizeLAI.Strategies.calcFracPopn _calcfracpopn = new SiriusQualityMaizeLAI.Strategies.calcFracPopn();
			SiriusQualityMaizeLAI.Strategies.calcInitTT _calcinittt = new SiriusQualityMaizeLAI.Strategies.calcInitTT();
			SiriusQualityMaizeLAI.Strategies.calcLER _calcler = new SiriusQualityMaizeLAI.Strategies.calcLER();
			SiriusQualityMaizeLAI.Strategies.calcLERCoeff _calclercoeff = new SiriusQualityMaizeLAI.Strategies.calcLERCoeff();
			SiriusQualityMaizeLAI.Strategies.calcLiguleTT _calcligulett = new SiriusQualityMaizeLAI.Strategies.calcLiguleTT();
			SiriusQualityMaizeLAI.Strategies.calcStartExpTT _calcstartexptt = new SiriusQualityMaizeLAI.Strategies.calcStartExpTT();
			SiriusQualityMaizeLAI.Strategies.calcStartEnlargeTT _calcstartenlargett = new SiriusQualityMaizeLAI.Strategies.calcStartEnlargeTT();
			SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT _calcstopenlargett = new SiriusQualityMaizeLAI.Strategies.calcStopEnlargeTT();
			SiriusQualityMaizeLAI.Strategies.calcTipTT _calctiptt = new SiriusQualityMaizeLAI.Strategies.calcTipTT();
			SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize _deltalaimaize = new SiriusQualityMaizeLAI.Strategies.DeltaLAIMaize();
			SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor _leafexpansiondroughtfactor = new SiriusQualityMaizeLAI.Strategies.LeafExpansionDroughtFactor();
			SiriusQualityMaizeLAI.Strategies.UpdateLeafArea _updateleafarea = new SiriusQualityMaizeLAI.Strategies.UpdateLeafArea();

			//Call of the associated strategies
			private void EstimateOfAssociatedClasses(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate,SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1,CRA.AgroManagement.ActEvents actevents){
                _calcfracpopn.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcler.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calclercoeff.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcinittt.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calctiptt.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcligulett.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcstartexptt.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcfullyexptt.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcbasewidth.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcstartenlargett.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _calcstopenlargett.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _leafexpansiondroughtfactor.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                _deltalaimaize.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
                resetDeltaAI(maizeleafstate);
			}

			#endregion


	#endregion


				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section2
				//Code written below will not be overwritten by a future code generation
                        /// <summary>
                /// copy constructor. We only need to copy the parameters (the strategies being stateless)
                /// </summary> 


            public void UpdateLeafArea(SiriusQualityMaizeLAI.MaizeLAIState maizelaistate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1, CRA.AgroManagement.ActEvents actevents)
            {
                _updateleafarea.Estimate(maizelaistate, maizeleafstate, maizeleafstate1, actevents);
            }

            public void resetDeltaAI(SiriusQualityMaizeLAI.MaizeLeafState wheatleafstate)
            {
                for (int ilayer = 0; ilayer < wheatleafstate.deltaAI.Count; ilayer++)
                {
                    wheatleafstate.deltaAI[ilayer] = 0;
                }
            }

            public MaizeLAI(MaizeLAI toCopy)
                : this()
            {


                Nfinal = toCopy.Nfinal;
                width6 = toCopy.width6;
                betaW = toCopy.betaW;
                sigmaW = toCopy.sigmaW;
                Lagmax = toCopy.Lagmax;
                Nlast = toCopy.Nlast;
                leafNoInitEmerg = toCopy.leafNoInitEmerg;
                LIR = toCopy.LIR;
                LERa = toCopy.LERa;
                LERb = toCopy.LERb;
                LERc = toCopy.LERc;
                Beta = toCopy.Beta;
                Sigma = toCopy.Sigma;
                b_ll1 = toCopy.b_ll1;
                k_ll = toCopy.k_ll;
                a_ll1 = toCopy.a_ll1;
                Dse = toCopy.Dse;
                alpha_tr = toCopy.alpha_tr;
                atip = toCopy.atip;
                k_bl = toCopy.k_bl;
                Nlim = toCopy.Nlim;
                btip = toCopy.btip;
                lagStopWidthExpand = toCopy.lagStopWidthExpand;
                plantDensity = toCopy.plantDensity;
                SensiRad = toCopy.SensiRad;
                radBase = toCopy.radBase;
                LowerFPAWexp = toCopy.LowerFPAWexp;
                UpperFPAWexp = toCopy.UpperFPAWexp;
                MaxDSF = toCopy.MaxDSF;
                LowerFPAWsen = toCopy.LowerFPAWsen;
                UpperFPAWsen = toCopy.UpperFPAWsen;
                UpperVPD = toCopy.UpperVPD;
                LowerVPD = toCopy.LowerVPD;
                SLNcri = toCopy.SLNcri;
                ttinitflo = toCopy.ttinitflo;


            }
				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section2 
	}
}
