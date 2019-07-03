

 //Author:pierre martre pierre.martre@inra.fr
 //Institution:Inra
 //Author of revision: 
 //Date first release:9/22/2017
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
//To make this project compile please add the reference to assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;

namespace SiriusQualityMaizeLAI.Strategies
{

	/// <summary>
	///Class DeltaLAIMaize
    /// Calculate State of the leaf and exposed leaf Area Index
    /// </summary>
	public class DeltaLAIMaize : IStrategySiriusQualityMaizeLAI
	{

	#region Constructor

			public DeltaLAIMaize()
			{
				
				ModellingOptions mo0_0 = new ModellingOptions();
				//Parameters
				List<VarInfo> _parameters0_0 = new List<VarInfo>();
				VarInfo v1 = new VarInfo();
				 v1.DefaultValue = 7.5;
				 v1.Description = "Plant Density";
				 v1.Id = 0;
				 v1.MaxValue = 10;
				 v1.MinValue = 0;
				 v1.Name = "plantDensity";
				 v1.Size = 1;
				 v1.Units = "m-²";
				 v1.URL = "";
				 v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v1);
				VarInfo v2 = new VarInfo();
				 v2.DefaultValue = 0.75;
				 v2.Description = "Width lef sensitivity to radiation";
				 v2.Id = 0;
				 v2.MaxValue = 10;
				 v2.MinValue = 0;
				 v2.Name = "SensiRad";
				 v2.Size = 1;
				 v2.Units = "cm/MJ intercepted m-²";
				 v2.URL = "";
				 v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v2);
				VarInfo v3 = new VarInfo();
				 v3.DefaultValue = 50;
				 v3.Description = "Base value for radiation effect on leaf widening";
				 v3.Id = 0;
				 v3.MaxValue = 10000;
				 v3.MinValue = 0;
				 v3.Name = "radBase";
				 v3.Size = 1;
				 v3.Units = "MJ";
				 v3.URL = "";
				 v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v3);
				mo0_0.Parameters=_parameters0_0;
				//Inputs
				List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd1 = new PropertyDescription();
				pd1.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd1.PropertyName = "cumulTTPHenoMaize";
				pd1.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.cumulTTPHenoMaize)).ValueType.TypeForCurrentValue;
				pd1.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.cumulTTPHenoMaize);
				_inputs0_0.Add(pd1);
				PropertyDescription pd2 = new PropertyDescription();
				pd2.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd2.PropertyName = "LER";
				pd2.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.LER)).ValueType.TypeForCurrentValue;
				pd2.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.LER);
				_inputs0_0.Add(pd2);
				PropertyDescription pd3 = new PropertyDescription();
				pd3.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd3.PropertyName = "deltaTTPhenoMaize";
				pd3.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.deltaTTPhenoMaize)).ValueType.TypeForCurrentValue;
				pd3.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.deltaTTPhenoMaize);
				_inputs0_0.Add(pd3);
				PropertyDescription pd4 = new PropertyDescription();
				pd4.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd4.PropertyName = "length";
				pd4.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length)).ValueType.TypeForCurrentValue;
				pd4.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length);
				_inputs0_0.Add(pd4);
				PropertyDescription pd5 = new PropertyDescription();
				pd5.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd5.PropertyName = "State";
				pd5.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State)).ValueType.TypeForCurrentValue;
				pd5.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
				_inputs0_0.Add(pd5);
				PropertyDescription pd6 = new PropertyDescription();
				pd6.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd6.PropertyName = "fullyExpTT";
				pd6.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fullyExpTT)).ValueType.TypeForCurrentValue;
				pd6.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fullyExpTT);
				_inputs0_0.Add(pd6);
				PropertyDescription pd7 = new PropertyDescription();
				pd7.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd7.PropertyName = "GAI";
				pd7.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI)).ValueType.TypeForCurrentValue;
				pd7.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI);
				_inputs0_0.Add(pd7);
				PropertyDescription pd8 = new PropertyDescription();
				pd8.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd8.PropertyName = "startExpTT";
				pd8.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startExpTT)).ValueType.TypeForCurrentValue;
				pd8.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startExpTT);
				_inputs0_0.Add(pd8);
				PropertyDescription pd9 = new PropertyDescription();
				pd9.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd9.PropertyName = "coefLER";
				pd9.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.coefLER)).ValueType.TypeForCurrentValue;
				pd9.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.coefLER);
				_inputs0_0.Add(pd9);
				PropertyDescription pd10 = new PropertyDescription();
				pd10.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd10.PropertyName = "fracPopn";
				pd10.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn)).ValueType.TypeForCurrentValue;
				pd10.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn);
				_inputs0_0.Add(pd10);
				PropertyDescription pd11 = new PropertyDescription();
				pd11.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd11.PropertyName = "tipTT";
				pd11.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.tipTT)).ValueType.TypeForCurrentValue;
				pd11.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.tipTT);
				_inputs0_0.Add(pd11);
				PropertyDescription pd12 = new PropertyDescription();
				pd12.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd12.PropertyName = "liguleTT";
				pd12.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT)).ValueType.TypeForCurrentValue;
				pd12.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT);
				_inputs0_0.Add(pd12);
				PropertyDescription pd13 = new PropertyDescription();
				pd13.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd13.PropertyName = "stopEnlargeTT";
				pd13.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.stopEnlargeTT)).ValueType.TypeForCurrentValue;
				pd13.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.stopEnlargeTT);
				_inputs0_0.Add(pd13);
				PropertyDescription pd14 = new PropertyDescription();
				pd14.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd14.PropertyName = "startEnlargeTT";
				pd14.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startEnlargeTT)).ValueType.TypeForCurrentValue;
				pd14.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startEnlargeTT);
				_inputs0_0.Add(pd14);
				PropertyDescription pd15 = new PropertyDescription();
				pd15.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd15.PropertyName = "leafAge";
				pd15.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge)).ValueType.TypeForCurrentValue;
				pd15.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge);
				_inputs0_0.Add(pd15);
				PropertyDescription pd16 = new PropertyDescription();
				pd16.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd16.PropertyName = "cumIntRad";
				pd16.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad)).ValueType.TypeForCurrentValue;
				pd16.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad);
				_inputs0_0.Add(pd16);
				PropertyDescription pd17 = new PropertyDescription();
				pd17.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd17.PropertyName = "radIntercepted";
				pd17.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.radIntercepted)).ValueType.TypeForCurrentValue;
				pd17.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.radIntercepted);
				_inputs0_0.Add(pd17);
				PropertyDescription pd18 = new PropertyDescription();
				pd18.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd18.PropertyName = "exposedArea";
				pd18.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea)).ValueType.TypeForCurrentValue;
				pd18.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea);
				_inputs0_0.Add(pd18);
				PropertyDescription pd19 = new PropertyDescription();
				pd19.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd19.PropertyName = "baseWidth";
				pd19.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.baseWidth)).ValueType.TypeForCurrentValue;
				pd19.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.baseWidth);
				_inputs0_0.Add(pd19);
				PropertyDescription pd20 = new PropertyDescription();
				pd20.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd20.PropertyName = "area";
				pd20.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area)).ValueType.TypeForCurrentValue;
				pd20.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area);
				_inputs0_0.Add(pd20);
				mo0_0.Inputs=_inputs0_0;
				//Outputs
				List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd21 = new PropertyDescription();
				pd21.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd21.PropertyName = "WaterLimitedPotDeltaAIList";
				pd21.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList)).ValueType.TypeForCurrentValue;
				pd21.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList);
				_outputs0_0.Add(pd21);
				PropertyDescription pd22 = new PropertyDescription();
				pd22.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd22.PropertyName = "potentialIncDeltaArea";
				pd22.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.potentialIncDeltaArea)).ValueType.TypeForCurrentValue;
				pd22.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.potentialIncDeltaArea);
				_outputs0_0.Add(pd22);
				PropertyDescription pd23 = new PropertyDescription();
				pd23.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd23.PropertyName = "length";
				pd23.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length)).ValueType.TypeForCurrentValue;
				pd23.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length);
				_outputs0_0.Add(pd23);
				PropertyDescription pd24 = new PropertyDescription();
				pd24.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd24.PropertyName = "State";
				pd24.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State)).ValueType.TypeForCurrentValue;
				pd24.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
				_outputs0_0.Add(pd24);
				PropertyDescription pd25 = new PropertyDescription();
				pd25.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd25.PropertyName = "PreviousState";
				pd25.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.PreviousState)).ValueType.TypeForCurrentValue;
				pd25.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.PreviousState);
				_outputs0_0.Add(pd25);
				PropertyDescription pd26 = new PropertyDescription();
				pd26.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd26.PropertyName = "width";
				pd26.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.width)).ValueType.TypeForCurrentValue;
				pd26.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.width);
				_outputs0_0.Add(pd26);
				PropertyDescription pd27 = new PropertyDescription();
				pd27.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd27.PropertyName = "cumIntRad";
				pd27.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad)).ValueType.TypeForCurrentValue;
				pd27.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad);
				_outputs0_0.Add(pd27);
				PropertyDescription pd28 = new PropertyDescription();
				pd28.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd28.PropertyName = "leafAge";
				pd28.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge)).ValueType.TypeForCurrentValue;
				pd28.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge);
				_outputs0_0.Add(pd28);
				PropertyDescription pd29 = new PropertyDescription();
				pd29.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd29.PropertyName = "exposedArea";
				pd29.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea)).ValueType.TypeForCurrentValue;
				pd29.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea);
				_outputs0_0.Add(pd29);
				PropertyDescription pd30 = new PropertyDescription();
				pd30.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd30.PropertyName = "area";
				pd30.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area)).ValueType.TypeForCurrentValue;
				pd30.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area);
				_outputs0_0.Add(pd30);
				mo0_0.Outputs=_outputs0_0;
				//Associated strategies
				List<string> lAssStrat0_0 = new List<string>();
				mo0_0.AssociatedStrategies = lAssStrat0_0;
				//Adding the modeling options to the modeling options manager
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
				get { return "Calculate State of the leaf and exposed leaf Area Index"; }
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
				_pd.Add("Creator", "pierre.martre@inra.fr");
				_pd.Add("Date", "9/22/2017");
				_pd.Add("Publisher", "Inra");
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

			
			public Double plantDensity
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("plantDensity");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'plantDensity' not found (or found null) in strategy 'DeltaLAIMaize'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("plantDensity");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'plantDensity' not found in strategy 'DeltaLAIMaize'");
				}
			}
			public Double SensiRad
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("SensiRad");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'SensiRad' not found (or found null) in strategy 'DeltaLAIMaize'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("SensiRad");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'SensiRad' not found in strategy 'DeltaLAIMaize'");
				}
			}
			public Double radBase
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("radBase");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'radBase' not found (or found null) in strategy 'DeltaLAIMaize'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("radBase");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'radBase' not found in strategy 'DeltaLAIMaize'");
				}
			}

			// Getter and setters for the value of the parameters of a composite strategy
			

	#endregion		

	
	#region Parameters initialization method
			
            /// <summary>
            /// Set parameter(s) current values to the default value
            /// </summary>
            public void SetParametersDefaultValue()
            {
				_modellingOptionsManager.SetParametersDefaultValue();
				 

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
                plantDensityVarInfo.Name = "plantDensity";
				plantDensityVarInfo.Description =" Plant Density";
				plantDensityVarInfo.MaxValue = 10;
				plantDensityVarInfo.MinValue = 0;
				plantDensityVarInfo.DefaultValue = 7.5;
				plantDensityVarInfo.Units = "m-²";
				plantDensityVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				SensiRadVarInfo.Name = "SensiRad";
				SensiRadVarInfo.Description =" Width lef sensitivity to radiation";
				SensiRadVarInfo.MaxValue = 10;
				SensiRadVarInfo.MinValue = 0;
				SensiRadVarInfo.DefaultValue = 0.75;
				SensiRadVarInfo.Units = "cm/MJ intercepted m-²";
				SensiRadVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				radBaseVarInfo.Name = "radBase";
				radBaseVarInfo.Description =" Base value for radiation effect on leaf widening";
				radBaseVarInfo.MaxValue = 10000;
				radBaseVarInfo.MinValue = 0;
				radBaseVarInfo.DefaultValue = 50;
				radBaseVarInfo.Units = "MJ";
				radBaseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				
       
			}

			//Parameters static VarInfo list 
			
				private static VarInfo _plantDensityVarInfo= new VarInfo();
				/// <summary> 
				///plantDensity VarInfo definition
				/// </summary>
				public static VarInfo plantDensityVarInfo
				{
					get { return _plantDensityVarInfo; }
				}
				private static VarInfo _SensiRadVarInfo= new VarInfo();
				/// <summary> 
				///SensiRad VarInfo definition
				/// </summary>
				public static VarInfo SensiRadVarInfo
				{
					get { return _SensiRadVarInfo; }
				}
				private static VarInfo _radBaseVarInfo= new VarInfo();
				/// <summary> 
				///radBase VarInfo definition
				/// </summary>
				public static VarInfo radBaseVarInfo
				{
					get { return _radBaseVarInfo; }
				}					
			
			//Parameters static VarInfo list of the composite class
						

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
					
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList.CurrentValue=maizelaistate.WaterLimitedPotDeltaAIList;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.potentialIncDeltaArea.CurrentValue=maizelaistate.potentialIncDeltaArea;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length.CurrentValue=maizeleafstate.length;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.CurrentValue=maizeleafstate.State;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.PreviousState.CurrentValue=maizeleafstate.PreviousState;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.width.CurrentValue=maizeleafstate.width;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad.CurrentValue=maizeleafstate.cumIntRad;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge.CurrentValue=maizeleafstate.leafAge;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea.CurrentValue=maizeleafstate.exposedArea;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area.CurrentValue=maizeleafstate.area;
					
					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();            
					
					
					RangeBasedCondition r21 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList);
					if(r21.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList.ValueType)){prc.AddCondition(r21);}
					RangeBasedCondition r22 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.potentialIncDeltaArea);
					if(r22.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.potentialIncDeltaArea.ValueType)){prc.AddCondition(r22);}
					RangeBasedCondition r23 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length);
					if(r23.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length.ValueType)){prc.AddCondition(r23);}
					RangeBasedCondition r24 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
					if(r24.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.ValueType)){prc.AddCondition(r24);}
					RangeBasedCondition r25 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.PreviousState);
					if(r25.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.PreviousState.ValueType)){prc.AddCondition(r25);}
					RangeBasedCondition r26 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.width);
					if(r26.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.width.ValueType)){prc.AddCondition(r26);}
					RangeBasedCondition r27 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad);
					if(r27.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad.ValueType)){prc.AddCondition(r27);}
					RangeBasedCondition r28 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge);
					if(r28.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge.ValueType)){prc.AddCondition(r28);}
					RangeBasedCondition r29 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea);
					if(r29.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea.ValueType)){prc.AddCondition(r29);}
					RangeBasedCondition r30 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area);
					if(r30.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area.ValueType)){prc.AddCondition(r30);}

					

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
					
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.cumulTTPHenoMaize.CurrentValue=maizelaistate.cumulTTPHenoMaize;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.LER.CurrentValue=maizelaistate.LER;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.deltaTTPhenoMaize.CurrentValue=maizelaistate.deltaTTPhenoMaize;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length.CurrentValue=maizeleafstate.length;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.CurrentValue=maizeleafstate.State;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fullyExpTT.CurrentValue=maizeleafstate.fullyExpTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI.CurrentValue=maizeleafstate.GAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startExpTT.CurrentValue=maizeleafstate.startExpTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.coefLER.CurrentValue=maizeleafstate.coefLER;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn.CurrentValue=maizeleafstate.fracPopn;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.tipTT.CurrentValue=maizeleafstate.tipTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT.CurrentValue=maizeleafstate.liguleTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.stopEnlargeTT.CurrentValue=maizeleafstate.stopEnlargeTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startEnlargeTT.CurrentValue=maizeleafstate.startEnlargeTT;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge.CurrentValue=maizeleafstate.leafAge;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad.CurrentValue=maizeleafstate.cumIntRad;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.radIntercepted.CurrentValue=maizelaistate.radIntercepted;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea.CurrentValue=maizeleafstate.exposedArea;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.baseWidth.CurrentValue=maizeleafstate.baseWidth;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area.CurrentValue=maizeleafstate.area;

					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();
            
					
					RangeBasedCondition r1 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.cumulTTPHenoMaize);
					if(r1.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.cumulTTPHenoMaize.ValueType)){prc.AddCondition(r1);}
					RangeBasedCondition r2 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.LER);
					if(r2.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.LER.ValueType)){prc.AddCondition(r2);}
					RangeBasedCondition r3 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.deltaTTPhenoMaize);
					if(r3.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.deltaTTPhenoMaize.ValueType)){prc.AddCondition(r3);}
					RangeBasedCondition r4 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length);
					if(r4.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.length.ValueType)){prc.AddCondition(r4);}
					RangeBasedCondition r5 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
					if(r5.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.ValueType)){prc.AddCondition(r5);}
					RangeBasedCondition r6 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fullyExpTT);
					if(r6.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fullyExpTT.ValueType)){prc.AddCondition(r6);}
					RangeBasedCondition r7 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI);
					if(r7.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI.ValueType)){prc.AddCondition(r7);}
					RangeBasedCondition r8 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startExpTT);
					if(r8.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startExpTT.ValueType)){prc.AddCondition(r8);}
					RangeBasedCondition r9 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.coefLER);
					if(r9.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.coefLER.ValueType)){prc.AddCondition(r9);}
					RangeBasedCondition r10 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn);
					if(r10.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn.ValueType)){prc.AddCondition(r10);}
					RangeBasedCondition r11 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.tipTT);
					if(r11.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.tipTT.ValueType)){prc.AddCondition(r11);}
					RangeBasedCondition r12 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT);
					if(r12.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT.ValueType)){prc.AddCondition(r12);}
					RangeBasedCondition r13 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.stopEnlargeTT);
					if(r13.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.stopEnlargeTT.ValueType)){prc.AddCondition(r13);}
					RangeBasedCondition r14 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startEnlargeTT);
					if(r14.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.startEnlargeTT.ValueType)){prc.AddCondition(r14);}
					RangeBasedCondition r15 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge);
					if(r15.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.leafAge.ValueType)){prc.AddCondition(r15);}
					RangeBasedCondition r16 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad);
					if(r16.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.cumIntRad.ValueType)){prc.AddCondition(r16);}
					RangeBasedCondition r17 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.radIntercepted);
					if(r17.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.radIntercepted.ValueType)){prc.AddCondition(r17);}
					RangeBasedCondition r18 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea);
					if(r18.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.exposedArea.ValueType)){prc.AddCondition(r18);}
					RangeBasedCondition r19 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.baseWidth);
					if(r19.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.baseWidth.ValueType)){prc.AddCondition(r19);}
					RangeBasedCondition r20 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area);
					if(r20.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.area.ValueType)){prc.AddCondition(r20);}
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("plantDensity")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SensiRad")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("radBase")));

					

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
				

				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section1
				//Code written below will not be overwritten by a future code generation
                //update the size of the lists
                for (int i = 0; i < maizeleafstate.length.Count; i++)
                {
                    //if a new leaf has appeared, increase the size of the arrays
                    if (i >= maizelaistate.WaterLimitedPotDeltaAIList.Count)
                    {
                        maizelaistate.WaterLimitedPotDeltaAIList.Add(0);
                        
                    }
                }

                CalculateNewLeafLayerStates(maizelaistate.cumulTTPHenoMaize, maizelaistate, maizeleafstate, maizeleafstate1);

                maizelaistate.potentialIncDeltaArea = calculateDeltaLAIpot(maizelaistate.cumulTTPHenoMaize, maizelaistate.deltaTTPhenoMaize, maizelaistate.LER,maizelaistate, maizeleafstate, maizeleafstate1);


				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section1 
			}

				

	#endregion


				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section2
            //Code written below will not be overwritten by a future code generation
            private void CalculateNewLeafLayerStates(double sumTTFromSowing, SiriusQualityMaizeLAI.MaizeLAIState maizelaistate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1)
                {
                    maizeleafstate1.State=new List<int>();
                    maizeleafstate.PreviousState = new List<int>();
                    for (int i = 0; i < maizeleafstate.length.Count; i++)
                    {
                        
                        maizeleafstate1.State.Add(maizeleafstate.State[i]);
                        maizeleafstate.PreviousState.Add(maizeleafstate1.State[i]);
                        switch (maizeleafstate.State[i])
                        //Leaf States: 0: Growing, 1:Mature, 2:Scenescing, 3:Dead
                        {
                            case 0:
                                if (sumTTFromSowing > maizeleafstate.liguleTT[i])
                                {
                                    maizeleafstate1.State[i] = 1;
                                } break; // take in account the growth of exposedFraction
                            case 1:
                                break;
                        }
                        maizeleafstate.State[i] = maizeleafstate1.State[i];
                    }
                }



            private double calculateDeltaLAIpot(double sumTTFromSowing, double deltaTT, double LER, SiriusQualityMaizeLAI.MaizeLAIState maizelaistate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate, SiriusQualityMaizeLAI.MaizeLeafState maizeleafstate1)
            {
                // some variables
                double ttElapsed = sumTTFromSowing - deltaTT;// ttElapsed doesn't include the tt for today
                double dltTT = deltaTT;
                double dltLERlai = 0;


                    //we don't calculate a deltaLAI but the whole new area
                for (int leafNo = 0; leafNo < maizeleafstate.length.Count; leafNo++)
                {

                    maizeleafstate.length[leafNo] = Math.Max(0.0, maizeleafstate.length[leafNo]);
                    maizeleafstate1.length[leafNo] = Math.Max(0.0, maizeleafstate1.length[leafNo]);
                    maizeleafstate.width[leafNo] = Math.Max(0.0, maizeleafstate.width[leafNo]);


                    double area = maizeleafstate.area[leafNo];
                    double exposedFraction = 1.0;


                    double previousExposedLAI = maizeleafstate.exposedArea[leafNo] * plantDensity / 1000000.0;

                    if (ttElapsed + dltTT > maizeleafstate.startExpTT[leafNo] &&
                       ttElapsed < maizeleafstate.fullyExpTT[leafNo]) //in growing period
                    {

                        #region Length
                        // some mucking around to take part days into account
                        double growthTT = Math.Min(dltTT, ttElapsed + dltTT - maizeleafstate.startExpTT[leafNo]);
                        growthTT = Math.Min(growthTT, maizeleafstate.fullyExpTT[leafNo] - ttElapsed);

                        double leaveLER;
                        leaveLER = SiriusQuality_MaizeLAI.Utilities.BasicMathUtilities.divide(LER * maizeleafstate.coefLER[leafNo], dltTT);      // expansion rate in mm/oCd   (LER in mm/day)

                        double dltLength = growthTT * leaveLER;      // mm
                        maizeleafstate1.length[leafNo] = Math.Max(0.0, maizeleafstate.length[leafNo] + dltLength);

                        #endregion

                        #region Width

                        // Calculate intercepted radiation per plant (mean for this growth day):

                        maizeleafstate1.leafAge[leafNo] = maizeleafstate.leafAge[leafNo] + 1;
                        double RADint = maizelaistate.radIntercepted;
                        double RADintperplant = RADint / plantDensity;
                        maizeleafstate1.cumIntRad[leafNo] = maizeleafstate.cumIntRad[leafNo] + RADintperplant;
                        double RADmean = maizeleafstate1.cumIntRad[leafNo] / maizeleafstate1.leafAge[leafNo];

                        double startW = maizeleafstate.startEnlargeTT[leafNo];
                        double stopW = maizeleafstate.stopEnlargeTT[leafNo];
                        
                        double RADeffect = (RADmean - radBase) * SensiRad;
                        maizeleafstate.width[leafNo] = Math.Max(0.0, (maizeleafstate.baseWidth[leafNo] + RADeffect));



                        #endregion

                        #region Area


                        double LeafWidthRatio = Math.Min(SiriusQuality_MaizeLAI.Utilities.BasicMathUtilities.divide((ttElapsed - startW), (stopW - startW)), 1);
                        double FormFactor = 0.5 + (LeafWidthRatio * 0.25);

                        area = maizeleafstate1.area[leafNo] = CalculateArea(maizeleafstate1.length[leafNo], maizeleafstate.width[leafNo], FormFactor);

       

                        #endregion


                        maizeleafstate.width[leafNo] = Math.Max(0.0, maizeleafstate.width[leafNo]);
                        maizeleafstate1.length[leafNo] = Math.Max(0.0, maizeleafstate1.length[leafNo]);
                        maizeleafstate.area[leafNo] = maizeleafstate1.area[leafNo];

                        maizeleafstate.leafAge[leafNo] = maizeleafstate1.leafAge[leafNo];
                        maizeleafstate.cumIntRad[leafNo] = maizeleafstate1.cumIntRad[leafNo];

                    }



                    if (maizeleafstate.length.Count > 0 && (ttElapsed +  dltTT < maizeleafstate.liguleTT[(int)(maizeleafstate.length.Count - 1)]))
                    {
                        exposedFraction = SiriusQuality_MaizeLAI.Utilities.BasicMathUtilities.divide((ttElapsed +  dltTT - maizeleafstate.tipTT[leafNo]),
                        (maizeleafstate.liguleTT[leafNo] - maizeleafstate.tipTT[leafNo]));
                        exposedFraction = Math.Max(Math.Min(exposedFraction, 1), 0);

                        maizeleafstate1.exposedArea[leafNo] = exposedFraction * area;//mm²

                        double ExposedLAI = maizeleafstate1.exposedArea[leafNo] * maizeleafstate.fracPopn[leafNo] * plantDensity / 1000000.0;


                        maizelaistate.WaterLimitedPotDeltaAIList[leafNo] = Math.Max(0.0, ExposedLAI - previousExposedLAI);//m²/m²

                        maizeleafstate.exposedArea[leafNo] = maizeleafstate1.exposedArea[leafNo];

                        dltLERlai += maizelaistate.WaterLimitedPotDeltaAIList[leafNo];


                    }

                    

                    
                }

                    dltLERlai = Math.Max(dltLERlai, 0.0);
                
                    return dltLERlai;
            }

            double CalculateArea(double length, double width, double FormFactor) {

                if (length < 0.0 || width < 0.0 || FormFactor<0.0) return 0.0; 
                else return length * width * FormFactor; 
            
            
            }

        //End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
        //PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section2 
	}
}
