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
/// This class was created from file C:\Users\mancealo\Documents\DesktopBU\Sirius-BioMa-MaizePotentialLAI-Component\SiriusQuality-MaizeLAI\XML\SiriusQualityMaizeLAI_MaizeLeafState.xml
/// The tool used was: DCC - Domain Class Coder, http://components.biomamodelling.org/, DCC
/// 
/// Loic Manceau
/// loic.manceau@inra.fr
/// INRA
/// 
/// 
/// 5/27/2019 4:53:37 PM
/// 
namespace SiriusQualityMaizeLAI
{
    using System;
    using CRA.ModelLayer.Core;
    
    
    /// <summary>MaizeLeafStateVarInfoClasses contain the attributes for each variable in the domain class RainData. Attributes are valorized via the static constructor. The data-type VarInfo causes  a dependency to the assembly CRA.Core.Preconditions.dll</summary>
    public class MaizeLeafStateVarInfo : IVarInfoClass
    {
        
        #region Private fields
        static VarInfo _State = new VarInfo();
        
        static VarInfo _liguleTT = new VarInfo();
        
        static VarInfo _fullyExpTT = new VarInfo();
        
        static VarInfo _GAI = new VarInfo();
        
        static VarInfo _length = new VarInfo();
        
        static VarInfo _width = new VarInfo();
        
        static VarInfo _fracPopn = new VarInfo();
        
        static VarInfo _startExpTT = new VarInfo();
        
        static VarInfo _baseWidth = new VarInfo();
        
        static VarInfo _area = new VarInfo();
        
        static VarInfo _coefLER = new VarInfo();
        
        static VarInfo _tipTT = new VarInfo();
        
        static VarInfo _exposedArea = new VarInfo();
        
        static VarInfo _PreviousState = new VarInfo();
        
        static VarInfo _isPrematurelyDying = new VarInfo();
        
        static VarInfo _startEnlargeTT = new VarInfo();
        
        static VarInfo _stopEnlargeTT = new VarInfo();
        
        static VarInfo _leafAge = new VarInfo();
        
        static VarInfo _cumIntRad = new VarInfo();
        
        static VarInfo _initialisationTT = new VarInfo();
        
        static VarInfo _deltaAI = new VarInfo();
        
        static VarInfo _LaminaAI = new VarInfo();
        
        static VarInfo _MaxAI = new VarInfo();
        #endregion
        
        /// <summary>Constructor</summary>
        static MaizeLeafStateVarInfo()
        {
            MaizeLeafStateVarInfo.DescribeVariables();
        }
        
        #region IVarInfoClass members
        /// <summary>Domain Class description</summary>
        public virtual  string Description
        {
            get
            {
                return "States for a leaf of maize";
            }
        }
        
        /// <summary>Reference to the ontology</summary>
        public  string URL
        {
            get
            {
                return "http://";
            }
        }
        
        /// <summary>Value domain class of reference</summary>
        public  string DomainClassOfReference
        {
            get
            {
                return "MaizeLeafState";
            }
        }
        #endregion
        
        #region Public properties
        /// <summary>State of the leaf, 0:Growing, 1:Mature,2:Senescing,3:Dead</summary>
        public static  VarInfo State
        {
            get
            {
                return  _State;
            }
        }
        
        /// <summary>TT at ligule appeareance</summary>
        public static  VarInfo liguleTT
        {
            get
            {
                return  _liguleTT;
            }
        }
        
        /// <summary>TT at initiation, when fully expanded (liguleTT - 50)</summary>
        public static  VarInfo fullyExpTT
        {
            get
            {
                return  _fullyExpTT;
            }
        }
        
        /// <summary>Green Area index (Lamina Area Index+Sheath Area Index</summary>
        public static  VarInfo GAI
        {
            get
            {
                return  _GAI;
            }
        }
        
        /// <summary>Leaf Length</summary>
        public static  VarInfo length
        {
            get
            {
                return  _length;
            }
        }
        
        /// <summary>Leaf width</summary>
        public static  VarInfo width
        {
            get
            {
                return  _width;
            }
        }
        
        /// <summary>fraction of Haun stage of the last leaf</summary>
        public static  VarInfo fracPopn
        {
            get
            {
                return  _fracPopn;
            }
        }
        
        /// <summary>Thermal Time at start of expansion (initTT + 100)</summary>
        public static  VarInfo startExpTT
        {
            get
            {
                return  _startExpTT;
            }
        }
        
        /// <summary>Potential Width</summary>
        public static  VarInfo baseWidth
        {
            get
            {
                return  _baseWidth;
            }
        }
        
        /// <summary>Area of the leave</summary>
        public static  VarInfo area
        {
            get
            {
                return  _area;
            }
        }
        
        /// <summary>Scaling factor from leaf 6 LER to the others r ranks</summary>
        public static  VarInfo coefLER
        {
            get
            {
                return  _coefLER;
            }
        }
        
        /// <summary>Thermal Time at tip emergence</summary>
        public static  VarInfo tipTT
        {
            get
            {
                return  _tipTT;
            }
        }
        
        /// <summary>Exposed area of the leaf</summary>
        public static  VarInfo exposedArea
        {
            get
            {
                return  _exposedArea;
            }
        }
        
        /// <summary>Previous State of the leaf, 0:Growing, 1:Mature,2:Senescing,3:Dead</summary>
        public static  VarInfo PreviousState
        {
            get
            {
                return  _PreviousState;
            }
        }
        
        /// <summary>Flag</summary>
        public static  VarInfo isPrematurelyDying
        {
            get
            {
                return  _isPrematurelyDying;
            }
        }
        
        /// <summary>Begining of leaf width extension</summary>
        public static  VarInfo startEnlargeTT
        {
            get
            {
                return  _startEnlargeTT;
            }
        }
        
        /// <summary>Stop of Leaf width expension</summary>
        public static  VarInfo stopEnlargeTT
        {
            get
            {
                return  _stopEnlargeTT;
            }
        }
        
        /// <summary>Leaf age</summary>
        public static  VarInfo leafAge
        {
            get
            {
                return  _leafAge;
            }
        }
        
        /// <summary>Cumulated Intercepted Radiations</summary>
        public static  VarInfo cumIntRad
        {
            get
            {
                return  _cumIntRad;
            }
        }
        
        /// <summary>Thermal Time At Initialisation</summary>
        public static  VarInfo initialisationTT
        {
            get
            {
                return  _initialisationTT;
            }
        }
        
        /// <summary>Increment in aera index of the day</summary>
        public static  VarInfo deltaAI
        {
            get
            {
                return  _deltaAI;
            }
        }
        
        /// <summary>Leaf lamina Area Index</summary>
        public static  VarInfo LaminaAI
        {
            get
            {
                return  _LaminaAI;
            }
        }
        
        /// <summary>Leaf maximum area index over the season</summary>
        public static  VarInfo MaxAI
        {
            get
            {
                return  _MaxAI;
            }
        }
        #endregion
        
        #region VarInfo values
        /// <summary>Set VarInfo values</summary>
        static void DescribeVariables()
        {
            //   
            _State.Name = "State";
            _State.Description = "State of the leaf, 0:Growing, 1:Mature,2:Senescing,3:Dead";
            _State.MaxValue = 3D;
            _State.MinValue = 0D;
            _State.DefaultValue = 0D;
            _State.Units = "dimensionless";
            _State.URL = "http://";
            _State.ValueType = VarInfoValueTypes.GetInstanceForName("ListInteger");
            //   
            _liguleTT.Name = "liguleTT";
            _liguleTT.Description = "TT at ligule appeareance";
            _liguleTT.MaxValue = 2000D;
            _liguleTT.MinValue = 0D;
            _liguleTT.DefaultValue = 0D;
            _liguleTT.Units = "°Cd";
            _liguleTT.URL = "http://";
            _liguleTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _fullyExpTT.Name = "fullyExpTT";
            _fullyExpTT.Description = "TT at initiation, when fully expanded (liguleTT - 50)";
            _fullyExpTT.MaxValue = 2000D;
            _fullyExpTT.MinValue = 0D;
            _fullyExpTT.DefaultValue = 0D;
            _fullyExpTT.Units = "°Cd";
            _fullyExpTT.URL = "http://";
            _fullyExpTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _GAI.Name = "GAI";
            _GAI.Description = "Green Area index (Lamina Area Index+Sheath Area Index";
            _GAI.MaxValue = 1D;
            _GAI.MinValue = 0D;
            _GAI.DefaultValue = 0D;
            _GAI.Units = "m²/m²";
            _GAI.URL = "http://";
            _GAI.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _length.Name = "length";
            _length.Description = "Leaf Length";
            _length.MaxValue = 1000D;
            _length.MinValue = 0D;
            _length.DefaultValue = 0D;
            _length.Units = "mm";
            _length.URL = "http://";
            _length.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _width.Name = "width";
            _width.Description = "Leaf width";
            _width.MaxValue = 1000D;
            _width.MinValue = 0D;
            _width.DefaultValue = 0D;
            _width.Units = "mm";
            _width.URL = "http://";
            _width.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _fracPopn.Name = "fracPopn";
            _fracPopn.Description = "fraction of Haun stage of the last leaf";
            _fracPopn.MaxValue = 0.9999D;
            _fracPopn.MinValue = 0D;
            _fracPopn.DefaultValue = 0D;
            _fracPopn.Units = "dimensionless";
            _fracPopn.URL = "http://";
            _fracPopn.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _startExpTT.Name = "startExpTT";
            _startExpTT.Description = "Thermal Time at start of expansion (initTT + 100)";
            _startExpTT.MaxValue = 2000D;
            _startExpTT.MinValue = 0D;
            _startExpTT.DefaultValue = 0D;
            _startExpTT.Units = "°Cd";
            _startExpTT.URL = "http://";
            _startExpTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _baseWidth.Name = "baseWidth";
            _baseWidth.Description = "Potential Width";
            _baseWidth.MaxValue = 1000D;
            _baseWidth.MinValue = 0D;
            _baseWidth.DefaultValue = 0D;
            _baseWidth.Units = "mm";
            _baseWidth.URL = "http://";
            _baseWidth.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _area.Name = "area";
            _area.Description = "Area of the leave";
            _area.MaxValue = 1000D;
            _area.MinValue = 0D;
            _area.DefaultValue = 0D;
            _area.Units = "mm²";
            _area.URL = "http://";
            _area.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _coefLER.Name = "coefLER";
            _coefLER.Description = "Scaling factor from leaf 6 LER to the others r ranks";
            _coefLER.MaxValue = 100D;
            _coefLER.MinValue = 0D;
            _coefLER.DefaultValue = 0D;
            _coefLER.Units = "dimessionless";
            _coefLER.URL = "http://";
            _coefLER.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _tipTT.Name = "tipTT";
            _tipTT.Description = "Thermal Time at tip emergence";
            _tipTT.MaxValue = 2000D;
            _tipTT.MinValue = 0D;
            _tipTT.DefaultValue = 0D;
            _tipTT.Units = "°Cd";
            _tipTT.URL = "http://";
            _tipTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _exposedArea.Name = "exposedArea";
            _exposedArea.Description = "Exposed area of the leaf";
            _exposedArea.MaxValue = 1000D;
            _exposedArea.MinValue = 0D;
            _exposedArea.DefaultValue = 0D;
            _exposedArea.Units = "mm²";
            _exposedArea.URL = "http://";
            _exposedArea.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _PreviousState.Name = "PreviousState";
            _PreviousState.Description = "Previous State of the leaf, 0:Growing, 1:Mature,2:Senescing,3:Dead";
            _PreviousState.MaxValue = 3D;
            _PreviousState.MinValue = 0D;
            _PreviousState.DefaultValue = 0D;
            _PreviousState.Units = "dimensionless";
            _PreviousState.URL = "http://";
            _PreviousState.ValueType = VarInfoValueTypes.GetInstanceForName("ListInteger");
            //   
            _isPrematurelyDying.Name = "isPrematurelyDying";
            _isPrematurelyDying.Description = "Flag";
            _isPrematurelyDying.MaxValue = 1D;
            _isPrematurelyDying.MinValue = 0D;
            _isPrematurelyDying.DefaultValue = 0D;
            _isPrematurelyDying.Units = "dimensionless";
            _isPrematurelyDying.URL = "http://";
            _isPrematurelyDying.ValueType = VarInfoValueTypes.GetInstanceForName("ListInteger");
            //   
            _startEnlargeTT.Name = "startEnlargeTT";
            _startEnlargeTT.Description = "Begining of leaf width extension";
            _startEnlargeTT.MaxValue = 10000D;
            _startEnlargeTT.MinValue = 0D;
            _startEnlargeTT.DefaultValue = 0D;
            _startEnlargeTT.Units = "°Cd";
            _startEnlargeTT.URL = "http://";
            _startEnlargeTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _stopEnlargeTT.Name = "stopEnlargeTT";
            _stopEnlargeTT.Description = "Stop of Leaf width expension";
            _stopEnlargeTT.MaxValue = 10000D;
            _stopEnlargeTT.MinValue = 0D;
            _stopEnlargeTT.DefaultValue = 0D;
            _stopEnlargeTT.Units = "°Cd";
            _stopEnlargeTT.URL = "http://";
            _stopEnlargeTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _leafAge.Name = "leafAge";
            _leafAge.Description = "Leaf age";
            _leafAge.MaxValue = 500D;
            _leafAge.MinValue = 0D;
            _leafAge.DefaultValue = 0D;
            _leafAge.Units = "days";
            _leafAge.URL = "http://";
            _leafAge.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _cumIntRad.Name = "cumIntRad";
            _cumIntRad.Description = "Cumulated Intercepted Radiations";
            _cumIntRad.MaxValue = 10D;
            _cumIntRad.MinValue = 0D;
            _cumIntRad.DefaultValue = 0D;
            _cumIntRad.Units = "MJ/m²";
            _cumIntRad.URL = "http://";
            _cumIntRad.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _initialisationTT.Name = "initialisationTT";
            _initialisationTT.Description = "Thermal Time At Initialisation";
            _initialisationTT.MaxValue = 10000D;
            _initialisationTT.MinValue = 0D;
            _initialisationTT.DefaultValue = 0D;
            _initialisationTT.Units = "°Cd";
            _initialisationTT.URL = "http://";
            _initialisationTT.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _deltaAI.Name = "deltaAI";
            _deltaAI.Description = "Increment in aera index of the day";
            _deltaAI.MaxValue = 1D;
            _deltaAI.MinValue = 0D;
            _deltaAI.DefaultValue = 0D;
            _deltaAI.Units = "m²/m²";
            _deltaAI.URL = "http://";
            _deltaAI.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _LaminaAI.Name = "LaminaAI";
            _LaminaAI.Description = "Leaf lamina Area Index";
            _LaminaAI.MaxValue = 1D;
            _LaminaAI.MinValue = 0D;
            _LaminaAI.DefaultValue = 0D;
            _LaminaAI.Units = "m²/m²";
            _LaminaAI.URL = "http://";
            _LaminaAI.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
            //   
            _MaxAI.Name = "MaxAI";
            _MaxAI.Description = "Leaf maximum area index over the season";
            _MaxAI.MaxValue = 1D;
            _MaxAI.MinValue = 0D;
            _MaxAI.DefaultValue = 0D;
            _MaxAI.Units = "m²/m²";
            _MaxAI.URL = "http://";
            _MaxAI.ValueType = VarInfoValueTypes.GetInstanceForName("ListDouble");
        }
        #endregion
    }
}
