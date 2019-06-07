

 //Author:Loic Manceau loic.manceau@inra.fr
 //Institution:INRA
 //Author of revision: 
 //Date first release:5/27/2019
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
	///Class UpdateLeafArea
    /// Increase  the lamina Area Index according to water and nitrogen stresses
    /// </summary>
	public class UpdateLeafArea : IStrategySiriusQualityMaizeLAI
	{

	#region Constructor

			public UpdateLeafArea()
			{
				
				ModellingOptions mo0_0 = new ModellingOptions();
				//Parameters
				List<VarInfo> _parameters0_0 = new List<VarInfo>();
				VarInfo v1 = new VarInfo();
				 v1.DefaultValue = 1.98;
				 v1.Description = "Critical area-based nitrogen content for leaf expansion";
				 v1.Id = 0;
				 v1.MaxValue = 100;
				 v1.MinValue = 0;
				 v1.Name = "SLNcri";
				 v1.Size = 1;
				 v1.Units = "g(N)/m²(leaf)";
				 v1.URL = "";
				 v1.VarType = CRA.ModelLayer.Core.VarInfo.Type.STATE;
				 v1.ValueType = VarInfoValueTypes.GetInstanceForName("Double");
				 _parameters0_0.Add(v1);
				mo0_0.Parameters=_parameters0_0;
				//Inputs
				List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd1 = new PropertyDescription();
				pd1.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd1.PropertyName = "incDeltaAreaLimitSF";
				pd1.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.incDeltaAreaLimitSF)).ValueType.TypeForCurrentValue;
				pd1.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.incDeltaAreaLimitSF);
				_inputs0_0.Add(pd1);
				PropertyDescription pd2 = new PropertyDescription();
				pd2.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd2.PropertyName = "availableN";
				pd2.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.availableN)).ValueType.TypeForCurrentValue;
				pd2.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.availableN);
				_inputs0_0.Add(pd2);
				PropertyDescription pd3 = new PropertyDescription();
				pd3.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd3.PropertyName = "MaxAI";
				pd3.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI)).ValueType.TypeForCurrentValue;
				pd3.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI);
				_inputs0_0.Add(pd3);
				PropertyDescription pd4 = new PropertyDescription();
				pd4.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd4.PropertyName = "LaminaAI";
				pd4.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI)).ValueType.TypeForCurrentValue;
				pd4.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI);
				_inputs0_0.Add(pd4);
				PropertyDescription pd5 = new PropertyDescription();
				pd5.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd5.PropertyName = "State";
				pd5.PropertyType = (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State)).ValueType.TypeForCurrentValue;
				pd5.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
				_inputs0_0.Add(pd5);
				PropertyDescription pd6 = new PropertyDescription();
				pd6.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd6.PropertyName = "WaterLimitedPotDeltaAIList";
				pd6.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList)).ValueType.TypeForCurrentValue;
				pd6.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList);
				_inputs0_0.Add(pd6);
				mo0_0.Inputs=_inputs0_0;
				//Outputs
				List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd7 = new PropertyDescription();
				pd7.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd7.PropertyName = "MaxAI";
				pd7.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI)).ValueType.TypeForCurrentValue;
				pd7.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI);
				_outputs0_0.Add(pd7);
				PropertyDescription pd8 = new PropertyDescription();
				pd8.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd8.PropertyName = "deltaAI";
				pd8.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.deltaAI)).ValueType.TypeForCurrentValue;
				pd8.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.deltaAI);
				_outputs0_0.Add(pd8);
				PropertyDescription pd9 = new PropertyDescription();
				pd9.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd9.PropertyName = "GAI";
				pd9.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI)).ValueType.TypeForCurrentValue;
				pd9.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI);
				_outputs0_0.Add(pd9);
				PropertyDescription pd10 = new PropertyDescription();
				pd10.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd10.PropertyName = "LaminaAI";
				pd10.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI)).ValueType.TypeForCurrentValue;
				pd10.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI);
				_outputs0_0.Add(pd10);
				PropertyDescription pd11 = new PropertyDescription();
				pd11.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd11.PropertyName = "IncDeltaArea";
				pd11.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.IncDeltaArea)).ValueType.TypeForCurrentValue;
				pd11.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.IncDeltaArea);
				_outputs0_0.Add(pd11);
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
				get { return "Increase  the lamina Area Index according to water and nitrogen stresses"; }
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
				_pd.Add("Date", "5/27/2019");
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

			
			public Double SLNcri
			{ 
				get {
						VarInfo vi= _modellingOptionsManager.GetParameterByName("SLNcri");
						if (vi != null && vi.CurrentValue!=null) return (Double)vi.CurrentValue ;
						else throw new Exception("Parameter 'SLNcri' not found (or found null) in strategy 'UpdateLeafArea'");
				 } set {
							VarInfo vi = _modellingOptionsManager.GetParameterByName("SLNcri");
							if (vi != null)  vi.CurrentValue=value;
						else throw new Exception("Parameter 'SLNcri' not found in strategy 'UpdateLeafArea'");
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
                SLNcriVarInfo.Name = "SLNcri";
				SLNcriVarInfo.Description =" Critical area-based nitrogen content for leaf expansion";
				SLNcriVarInfo.MaxValue = 100;
				SLNcriVarInfo.MinValue = 0;
				SLNcriVarInfo.DefaultValue = 1.98;
				SLNcriVarInfo.Units = "g(N)/m²(leaf)";
				SLNcriVarInfo.ValueType = CRA.ModelLayer.Core.VarInfoValueTypes.GetInstanceForName("Double");

				
       
			}

			//Parameters static VarInfo list 
			
				private static VarInfo _SLNcriVarInfo= new VarInfo();
				/// <summary> 
				///SLNcri VarInfo definition
				/// </summary>
				public static VarInfo SLNcriVarInfo
				{
					get { return _SLNcriVarInfo; }
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
					
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI.CurrentValue=maizeleafstate.MaxAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.deltaAI.CurrentValue=maizeleafstate.deltaAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI.CurrentValue=maizeleafstate.GAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI.CurrentValue=maizeleafstate.LaminaAI;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.IncDeltaArea.CurrentValue=maizelaistate.IncDeltaArea;
					
					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();            
					
					
					RangeBasedCondition r7 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI);
					if(r7.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI.ValueType)){prc.AddCondition(r7);}
					RangeBasedCondition r8 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.deltaAI);
					if(r8.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.deltaAI.ValueType)){prc.AddCondition(r8);}
					RangeBasedCondition r9 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI);
					if(r9.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.GAI.ValueType)){prc.AddCondition(r9);}
					RangeBasedCondition r10 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI);
					if(r10.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI.ValueType)){prc.AddCondition(r10);}
					RangeBasedCondition r11 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.IncDeltaArea);
					if(r11.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.IncDeltaArea.ValueType)){prc.AddCondition(r11);}

					

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
					
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.incDeltaAreaLimitSF.CurrentValue=maizelaistate.incDeltaAreaLimitSF;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.availableN.CurrentValue=maizelaistate.availableN;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI.CurrentValue=maizeleafstate.MaxAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI.CurrentValue=maizeleafstate.LaminaAI;
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.CurrentValue=maizeleafstate.State;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList.CurrentValue=maizelaistate.WaterLimitedPotDeltaAIList;

					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();
            
					
					RangeBasedCondition r1 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.incDeltaAreaLimitSF);
					if(r1.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.incDeltaAreaLimitSF.ValueType)){prc.AddCondition(r1);}
					RangeBasedCondition r2 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.availableN);
					if(r2.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.availableN.ValueType)){prc.AddCondition(r2);}
					RangeBasedCondition r3 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI);
					if(r3.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.MaxAI.ValueType)){prc.AddCondition(r3);}
					RangeBasedCondition r4 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI);
					if(r4.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.LaminaAI.ValueType)){prc.AddCondition(r4);}
					RangeBasedCondition r5 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State);
					if(r5.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.State.ValueType)){prc.AddCondition(r5);}
					RangeBasedCondition r6 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList);
					if(r6.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.WaterLimitedPotDeltaAIList.ValueType)){prc.AddCondition(r6);}
					prc.AddCondition(new RangeBasedCondition(_modellingOptionsManager.GetParameterByName("SLNcri")));

					

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

                if (maizelaistate.potentialIncDeltaArea > 0.0)
                {

                    if (maizelaistate.incDeltaAreaLimitSF == 0.0)
                    {
                        maizelaistate.IncDeltaArea = 0;
                    }
                    else
                    {
                        maizelaistate.IncDeltaArea = maizelaistate.incDeltaAreaLimitSF * Math.Min(1.0, maizelaistate.availableN / (maizelaistate.incDeltaAreaLimitSF * SLNcri));
                        IsNumber(maizelaistate.IncDeltaArea);

                    }

                    double stressGrowth = maizelaistate.IncDeltaArea / maizelaistate.potentialIncDeltaArea;

                    for (int ilayer = 0; ilayer < maizeleafstate.GAI.Count; ilayer++)
                    {
                        if (maizelaistate.WaterLimitedPotDeltaAIList[ilayer] > 0.0) // leaf layer is growing
                        {
                            IsNumber(stressGrowth);
                            maizeleafstate.deltaAI[ilayer] = maizelaistate.WaterLimitedPotDeltaAIList[ilayer] * stressGrowth;

                            maizeleafstate1.LaminaAI[ilayer] = maizeleafstate1.LaminaAI[ilayer] + maizeleafstate.deltaAI[ilayer];
                            maizeleafstate.LaminaAI[ilayer] = maizeleafstate1.LaminaAI[ilayer];


                            maizeleafstate.GAI[ilayer] = maizeleafstate.LaminaAI[ilayer];

                            maizeleafstate1.MaxAI[ilayer] = Math.Max(maizeleafstate.MaxAI[ilayer], maizeleafstate.GAI[ilayer]);
                            maizeleafstate.MaxAI[ilayer] = maizeleafstate1.MaxAI[ilayer];
                        }

                    }

                }
                else maizelaistate.IncDeltaArea = 0;


				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section1 
			}

				

	#endregion


				//GENERATED CODE END - PLACE YOUR CUSTOM CODE BELOW - Section2
				//Code written below will not be overwritten by a future code generation
            public static void IsNumber(double value)
            {
                // Console.WriteLine("valeur" + value);
                if (double.IsNaN(value) || double.IsInfinity(value))
                {
                    throw new ArgumentOutOfRangeException("value", "incDeltaArea" + ": is not a number.");
                }
            }
				//End of custom code. Do not place your custom code below. It will be overwritten by a future code generation.
				//PLACE YOUR CUSTOM CODE ABOVE - GENERATED CODE START - Section2 
	}
}
