

 //Author:Loic Manceau loic.manceau@inra.fr
 //Institution:INRA
 //Author of revision: 
 //Date first release:9/25/2017
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
	///Class calcLiguleTT
    /// Calculate Thermal Time of ligule appeareance
    /// </summary>
	public class calcLiguleTT : IStrategySiriusQualityMaizeLAI
	{

	#region Constructor

			public calcLiguleTT()
			{
				
				ModellingOptions mo0_0 = new ModellingOptions();
				//Parameters
				List<VarInfo> _parameters0_0 = new List<VarInfo>();
				VarInfo v1 = new VarInfo();
				 v1.DefaultValue = 137;
				 v1.Description = "Intercept of the regression of thermal time with tip appearance";
				 v1.Id = 0;
				 v1.MaxValue = 10000;
				 v1.MinValue = 0;
				 v1.Name = "b_ll1";
				 v1.Size = 1;
				 v1.Units = "°Cd";
				 v1.URL = "";
				 v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v1);
				VarInfo v2 = new VarInfo();
				 v2.DefaultValue = 2.4;
				 v2.Description = "fraction of the leaf ligulation slope corresponding to the upper group of maize leaves";
				 v2.Id = 0;
				 v2.MaxValue = 10;
				 v2.MinValue = 0;
				 v2.Name = "k_ll";
				 v2.Size = 1;
				 v2.Units = "dimensionless";
				 v2.URL = "";
				 v2.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v2.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v2);
				VarInfo v3 = new VarInfo();
				 v3.DefaultValue = 100;
				 v3.Description = "Phyllochron of first phase of ligulation";
				 v3.Id = 0;
				 v3.MaxValue = 1000;
				 v3.MinValue = 0;
				 v3.Name = "a_ll1";
				 v3.Size = 1;
				 v3.Units = "°Cd/leaf";
				 v3.URL = "";
				 v3.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v3.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v3);
				VarInfo v4 = new VarInfo();
				 v4.DefaultValue = 16;
				 v4.Description = "Final Leaf Number";
				 v4.Id = 0;
				 v4.MaxValue = 30;
				 v4.MinValue = 0;
				 v4.Name = "Nfinal";
				 v4.Size = 1;
				 v4.Units = "leaf";
				 v4.URL = "";
				 v4.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v4.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v4);
				VarInfo v5 = new VarInfo();
				 v5.DefaultValue = 190;
				 v5.Description = "Thermal time from sowing to emergence";
				 v5.Id = 0;
				 v5.MaxValue = 500;
				 v5.MinValue = 0;
				 v5.Name = "Dse";
				 v5.Size = 1;
				 v5.Units = "°Cd";
				 v5.URL = "";
				 v5.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v5.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v5);
				VarInfo v6 = new VarInfo();
				 v6.DefaultValue = 0.5;
				 v6.Description = "Fraction of Final leaf number corresponding to the lower group of Maize leaves";
				 v6.Id = 0;
				 v6.MaxValue = 1;
				 v6.MinValue = 0;
				 v6.Name = "alpha_tr";
				 v6.Size = 1;
				 v6.Units = "dimensionless";
				 v6.URL = "";
				 v6.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v6.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v6);
				mo0_0.Parameters=_parameters0_0;
				//Inputs
				List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd1 = new PropertyDescription();
				pd1.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd1.PropertyName = "leafNumber";
				pd1.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber)).ValueType.TypeForCurrentValue;
				pd1.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber);
				_inputs0_0.Add(pd1);
				PropertyDescription pd2 = new PropertyDescription();
				pd2.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd2.PropertyName = "previousLeafNumber";
				pd2.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber)).ValueType.TypeForCurrentValue;
				pd2.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber);
				_inputs0_0.Add(pd2);
				PropertyDescription pd3 = new PropertyDescription();
				pd3.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd3.PropertyName = "newLeafHasAppeared";
				pd3.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared)).ValueType.TypeForCurrentValue;
				pd3.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared);
				_inputs0_0.Add(pd3);
				mo0_0.Inputs=_inputs0_0;
				//Outputs
				List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd4 = new PropertyDescription();
				pd4.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd4.PropertyName = "liguleTT";
				pd4.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT)).ValueType.TypeForCurrentValue;
				pd4.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT);
				_outputs0_0.Add(pd4);
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
				get { return "Calculate Thermal Time of ligule appeareance"; }
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
				_pd.Add("Date", "9/25/2017");
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

			
			public Double b_ll1
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("b_ll1");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'b_ll1' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("b_ll1");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'b_ll1' not found in strategy 'calcLiguleTT'");
				}
			}
			public Double k_ll
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("k_ll");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'k_ll' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("k_ll");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'k_ll' not found in strategy 'calcLiguleTT'");
				}
			}
			public Double a_ll1
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("a_ll1");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'a_ll1' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("a_ll1");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'a_ll1' not found in strategy 'calcLiguleTT'");
				}
			}
			public Double Nfinal
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("Nfinal");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'Nfinal' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("Nfinal");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'Nfinal' not found in strategy 'calcLiguleTT'");
				}
			}
			public Double Dse
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("Dse");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'Dse' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("Dse");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'Dse' not found in strategy 'calcLiguleTT'");
				}
			}
			public Double alpha_tr
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("alpha_tr");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'alpha_tr' not found (or found null) in strategy 'calcLiguleTT'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("alpha_tr");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'alpha_tr' not found in strategy 'calcLiguleTT'");
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
                b_ll1VarInfo.Name = "b_ll1";
				b_ll1VarInfo.Description =" Intercept of the regression of thermal time with tip appearance";
				b_ll1VarInfo.MaxValue = 10000;
				b_ll1VarInfo.MinValue = 0;
				b_ll1VarInfo.DefaultValue = 137;
				b_ll1VarInfo.Units = "°Cd";
				b_ll1VarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				k_llVarInfo.Name = "k_ll";
				k_llVarInfo.Description =" fraction of the leaf ligulation slope corresponding to the upper group of maize leaves";
				k_llVarInfo.MaxValue = 10;
				k_llVarInfo.MinValue = 0;
				k_llVarInfo.DefaultValue = 2.4;
				k_llVarInfo.Units = "dimensionless";
				k_llVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				a_ll1VarInfo.Name = "a_ll1";
				a_ll1VarInfo.Description =" Phyllochron of first phase of ligulation";
				a_ll1VarInfo.MaxValue = 1000;
				a_ll1VarInfo.MinValue = 0;
				a_ll1VarInfo.DefaultValue = 100;
				a_ll1VarInfo.Units = "°Cd/leaf";
				a_ll1VarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				NfinalVarInfo.Name = "Nfinal";
				NfinalVarInfo.Description =" Final Leaf Number";
				NfinalVarInfo.MaxValue = 30;
				NfinalVarInfo.MinValue = 0;
				NfinalVarInfo.DefaultValue = 16;
				NfinalVarInfo.Units = "leaf";
				NfinalVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				DseVarInfo.Name = "Dse";
				DseVarInfo.Description =" Thermal time from sowing to emergence";
				DseVarInfo.MaxValue = 500;
				DseVarInfo.MinValue = 0;
				DseVarInfo.DefaultValue = 190;
				DseVarInfo.Units = "°Cd";
				DseVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				alpha_trVarInfo.Name = "alpha_tr";
				alpha_trVarInfo.Description =" Fraction of Final leaf number corresponding to the lower group of Maize leaves";
				alpha_trVarInfo.MaxValue = 1;
				alpha_trVarInfo.MinValue = 0;
				alpha_trVarInfo.DefaultValue = 0.5;
				alpha_trVarInfo.Units = "dimensionless";
				alpha_trVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				
       
			}

			//Parameters static VarInfo list 
			
				private static VarInfo _b_ll1VarInfo= new VarInfo();
				/// <summary> 
				///b_ll1 VarInfo definition
				/// </summary>
				public static VarInfo b_ll1VarInfo
				{
					get { return _b_ll1VarInfo; }
				}
				private static VarInfo _k_llVarInfo= new VarInfo();
				/// <summary> 
				///k_ll VarInfo definition
				/// </summary>
				public static VarInfo k_llVarInfo
				{
					get { return _k_llVarInfo; }
				}
				private static VarInfo _a_ll1VarInfo= new VarInfo();
				/// <summary> 
				///a_ll1 VarInfo definition
				/// </summary>
				public static VarInfo a_ll1VarInfo
				{
					get { return _a_ll1VarInfo; }
				}
				private static VarInfo _NfinalVarInfo= new VarInfo();
				/// <summary> 
				///Nfinal VarInfo definition
				/// </summary>
				public static VarInfo NfinalVarInfo
				{
					get { return _NfinalVarInfo; }
				}
				private static VarInfo _DseVarInfo= new VarInfo();
				/// <summary> 
				///Dse VarInfo definition
				/// </summary>
				public static VarInfo DseVarInfo
				{
					get { return _DseVarInfo; }
				}
				private static VarInfo _alpha_trVarInfo= new VarInfo();
				/// <summary> 
				///alpha_tr VarInfo definition
				/// </summary>
				public static VarInfo alpha_trVarInfo
				{
					get { return _alpha_trVarInfo; }
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
					
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT.CurrentValue=maizeleafstate.liguleTT;
					
					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();            
					
					
					RangeBasedCondition r4 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT);
					if(r4.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.liguleTT.ValueType)){prc.AddCondition(r4);}

					

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
					
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber.CurrentValue=maizelaistate.leafNumber;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber.CurrentValue=maizelaistate.previousLeafNumber;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared.CurrentValue=maizelaistate.newLeafHasAppeared;

					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();
            
					
					RangeBasedCondition r1 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber);
					if(r1.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber.ValueType)){prc.AddCondition(r1);}
					RangeBasedCondition r2 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber);
					if(r2.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber.ValueType)){prc.AddCondition(r2);}
					RangeBasedCondition r3 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared);
					if(r3.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared.ValueType)){prc.AddCondition(r3);}
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("b_ll1")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("k_ll")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("a_ll1")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Nfinal")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("Dse")));
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("alpha_tr")));

					

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

                if (maizelaistate.newLeafHasAppeared == 1)
                {
                    var newNbLayer = (int)Math.Ceiling(maizelaistate.leafNumber);
                    var curNbLayer = (int)Math.Ceiling(maizelaistate.previousLeafNumber);

                    for (var index = curNbLayer; index < newNbLayer; ++index)
                    {

                        // For ligulation :
                        // ----------------

                       
                        double N_limll = alpha_tr * Nfinal;
                        double b_ll2 = a_ll1 * N_limll * (1 - k_ll) + b_ll1;
                        double a_ll2 = k_ll * a_ll1;

                        double leafnum = index + 1;
                        if (leafnum <= N_limll)
                        {
                            // Add tt_to_emerg (TTem):
                            maizeleafstate.liguleTT[index] = a_ll1 * leafnum + b_ll1 + Dse;
                        }
                        else
                        {
                            // Add tt_to_emerg (TTem):
                            maizeleafstate.liguleTT[index] = a_ll2 * leafnum + b_ll2 + Dse;
                        }

                    }
                }

				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section1 
			}

				

	#endregion


				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section2
				//Code written below will not be overwritten by a future code generation

				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section2 
	}
}
