//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

/// 
/// This class was created from file C:\Users\mancealo\Documents\DesktopBU\Sirius-BioMa-MaizePotentialLAI-Component\SiriusQuality-MaizeLAI\XML\SiriusQualityMaizeLAI_MaizeLAIState.xml
/// The tool used was: DCC - Domain Class Coder, http://components.biomamodelling.org/, DCC
/// 
/// Loic Manceau
/// loic.manceau@inra.fr
/// INRA
/// 
/// 
/// 6/3/2019 3:12:46 PM
/// 
namespace SiriusQualityMaizeLAI
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using CRA.ModelLayer.Core;
    using CRA.ModelLayer.ParametersManagement;
    
    
    /// <summary>MaizeLAIState Domain class contains the accessors to values</summary>
    [Serializable()]
    public class MaizeLAIState : ICloneable, IDomainClass
    {
        
        #region Private fields
        private int _newLeafHasAppeared;
        
        private double _leafNumber;
        
        private double _finalLeafNumber;
        
        private double _FPAW;
        
        private int _isPotentialLAI;
        
        private double _VPDairCanopy;
        
        private double _DSF;
        
        private double _DEF;
        
        private double _incDeltaAreaLimitSF;
        
        private System.Collections.Generic.List<double> _WaterLimitedPotDeltaAIList = new List<double>();
        
        private double _potentialIncDeltaArea;
        
        private double[] _TCanopyHourly = new double[24];
        
        private double[] _VPDeq = new double[24];
        
        private double[] _hLER = new double[24];
        
        private double _LER;
        
        private double _cumulTTPHenoMaize;
        
        private double _deltaTTPhenoMaize;
        
        private double _previousLeafNumber;
        
        private double _radIntercepted;
        
        private double _IncDeltaArea;
        
        private double _availableN;
        #endregion
        
        #region Private field for properties
        private ParametersIO _parametersIO;
        #endregion
        
        #region Constructor
        /// <summary>No parameters constructor</summary>
        public MaizeLAIState()
        {
            _parametersIO = new ParametersIO(this);
        }

        public MaizeLAIState(MaizeLAIState toCopy)
        {
            _LER = toCopy.LER;

            _newLeafHasAppeared = toCopy.newLeafHasAppeared;

            _leafNumber = toCopy.leafNumber;

            _finalLeafNumber = toCopy.finalLeafNumber;

            _IncDeltaArea = toCopy._IncDeltaArea;

            _availableN = toCopy._availableN;

            _FPAW = toCopy.FPAW;

            _isPotentialLAI = toCopy.isPotentialLAI;

            _VPDairCanopy = toCopy.VPDairCanopy;

            _DSF = toCopy.DSF;

            _DEF = toCopy.DEF;

            _incDeltaAreaLimitSF = toCopy.incDeltaAreaLimitSF;

            _potentialIncDeltaArea = toCopy.potentialIncDeltaArea;

            _TCanopyHourly = new double[24];
            _VPDeq = new double[24];
            _hLER = new double[24];
            for (int i = 0; i < 24; i++)
            {

                _TCanopyHourly[i] = toCopy._TCanopyHourly[i];

                _VPDeq[i] = toCopy._VPDeq[i];

                _hLER[i] = toCopy.hLER[i];
            }


            _cumulTTPHenoMaize = toCopy.cumulTTPHenoMaize;

            _deltaTTPhenoMaize = toCopy.deltaTTPhenoMaize;

            _radIntercepted = toCopy._radIntercepted;

            System.Collections.Generic.List<double> _WaterLimitedPotDeltaAIList = new List<double>(toCopy._WaterLimitedPotDeltaAIList);
        }

        #endregion
        
        #region Public properties
        /// <summary></summary>
        public int newLeafHasAppeared
        {
            get
            {
                return this._newLeafHasAppeared;
            }
            set
            {
                this._newLeafHasAppeared = value;
            }
        }
        
        /// <summary> </summary>
        public double leafNumber
        {
            get
            {
                return this._leafNumber;
            }
            set
            {
                this._leafNumber = value;
            }
        }
        
        /// <summary> </summary>
        public double finalLeafNumber
        {
            get
            {
                return this._finalLeafNumber;
            }
            set
            {
                this._finalLeafNumber = value;
            }
        }
        
        /// <summary>Fraction of plant available water</summary>
        public double FPAW
        {
            get
            {
                return this._FPAW;
            }
            set
            {
                this._FPAW = value;
            }
        }
        
        /// <summary> </summary>
        public int isPotentialLAI
        {
            get
            {
                return this._isPotentialLAI;
            }
            set
            {
                this._isPotentialLAI = value;
            }
        }
        
        /// <summary> </summary>
        public double VPDairCanopy
        {
            get
            {
                return this._VPDairCanopy;
            }
            set
            {
                this._VPDairCanopy = value;
            }
        }
        
        /// <summary>drought senescence factor</summary>
        public double DSF
        {
            get
            {
                return this._DSF;
            }
            set
            {
                this._DSF = value;
            }
        }
        
        /// <summary>drought expansion factor</summary>
        public double DEF
        {
            get
            {
                return this._DEF;
            }
            set
            {
                this._DEF = value;
            }
        }
        
        /// <summary> </summary>
        public double incDeltaAreaLimitSF
        {
            get
            {
                return this._incDeltaAreaLimitSF;
            }
            set
            {
                this._incDeltaAreaLimitSF = value;
            }
        }
        
        /// <summary>list on each phytomer</summary>
        public System.Collections.Generic.List<double> WaterLimitedPotDeltaAIList
        {
            get
            {
                return this._WaterLimitedPotDeltaAIList;
            }
            set
            {
                this._WaterLimitedPotDeltaAIList = value;
            }
        }
        
        /// <summary> </summary>
        public double potentialIncDeltaArea
        {
            get
            {
                return this._potentialIncDeltaArea;
            }
            set
            {
                this._potentialIncDeltaArea = value;
            }
        }
        
        /// <summary></summary>
        public double[] TCanopyHourly
        {
            get
            {
                return this._TCanopyHourly;
            }
            set
            {
                this._TCanopyHourly = value;
            }
        }
        
        /// <summary></summary>
        public double[] VPDeq
        {
            get
            {
                return this._VPDeq;
            }
            set
            {
                this._VPDeq = value;
            }
        }
        
        /// <summary> Hourly Leaf elongation rate of the sixth leaf</summary>
        public double[] hLER
        {
            get
            {
                return this._hLER;
            }
            set
            {
                this._hLER = value;
            }
        }
        
        /// <summary>Mean daily Elongation rate of the sixth leaf</summary>
        public double LER
        {
            get
            {
                return this._LER;
            }
            set
            {
                this._LER = value;
            }
        }
        
        /// <summary></summary>
        public double cumulTTPHenoMaize
        {
            get
            {
                return this._cumulTTPHenoMaize;
            }
            set
            {
                this._cumulTTPHenoMaize = value;
            }
        }
        
        /// <summary></summary>
        public double deltaTTPhenoMaize
        {
            get
            {
                return this._deltaTTPhenoMaize;
            }
            set
            {
                this._deltaTTPhenoMaize = value;
            }
        }
        
        /// <summary>Previous time step leaf number</summary>
        public double previousLeafNumber
        {
            get
            {
                return this._previousLeafNumber;
            }
            set
            {
                this._previousLeafNumber = value;
            }
        }
        
        /// <summary>Total Radiation Intercepted by shoot</summary>
        public double radIntercepted
        {
            get
            {
                return this._radIntercepted;
            }
            set
            {
                this._radIntercepted = value;
            }
        }
        
        /// <summary>Increment in Area Index under drought and Nitrogen stress</summary>
        public double IncDeltaArea
        {
            get
            {
                return this._IncDeltaArea;
            }
            set
            {
                this._IncDeltaArea = value;
            }
        }
        
        /// <summary>Available Nitrogen</summary>
        public double availableN
        {
            get
            {
                return this._availableN;
            }
            set
            {
                this._availableN = value;
            }
        }
        #endregion
        
        #region IDomainClass members
        /// <summary>Domain Class description</summary>
        public virtual  string Description
        {
            get
            {
                return "Domain class description";
            }
        }
        
        /// <summary>Domain Class URL</summary>
        public virtual  string URL
        {
            get
            {
                return "http://";
            }
        }
        
        /// <summary>Domain Class Properties</summary>
        public virtual IDictionary<string, PropertyInfo> PropertiesDescription
        {
            get
            {
                return _parametersIO.GetCachedProperties(typeof(IDomainClass));
            }
        }
        #endregion
        
        /// <summary>Clears the values of the properties of the domain class by using the default value for the type of each property (e.g '0' for numbers, 'the empty string' for strings, etc.)</summary>
        public virtual Boolean ClearValues()
        {
            _newLeafHasAppeared = default(System.Int32);
            _leafNumber = default(System.Double);
            _finalLeafNumber = default(System.Double);
            _FPAW = default(System.Double);
            _isPotentialLAI = default(System.Int32);
            _VPDairCanopy = default(System.Double);
            _DSF = default(System.Double);
            _DEF = default(System.Double);
            _incDeltaAreaLimitSF = default(System.Double);
            _WaterLimitedPotDeltaAIList = new List<double>();
            _potentialIncDeltaArea = default(System.Double);
            _TCanopyHourly = new double[24];
            _VPDeq = new double[24];
            _hLER = new double[24];
            _LER = default(System.Double);
            _cumulTTPHenoMaize = default(System.Double);
            _deltaTTPhenoMaize = default(System.Double);
            _previousLeafNumber = default(System.Double);
            _radIntercepted = default(System.Double);
            _IncDeltaArea = default(System.Double);
            _availableN = default(System.Double);
            // Returns true if everything is ok
            return true;
        }
        
        #region Clone
        /// <summary>Implement ICloneable.Clone()</summary>
        public virtual Object Clone()
        {
            // Shallow copy by default
            IDomainClass myclass = (IDomainClass) this.MemberwiseClone();
            _parametersIO.PopulateClonedCopy(myclass);
            return myclass;
        }
        #endregion
    }
}
