

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
//To make this project compile please add the reference to assembly: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;

namespace SiriusQualityMaizeLAI.Strategies
{

	/// <summary>
	///Class calcFracPopn
    /// Decimal part of the haun stage for the final leaf. Unity for other leaves
    /// </summary>
	public class calcFracPopn : IStrategySiriusQualityMaizeLAI
	{

	#region Constructor

			public calcFracPopn()
			{
				
				ModellingOptions mo0_0 = new ModellingOptions();
				//Parameters
				List<VarInfo> _parameters0_0 = new List<VarInfo>();
				mo0_0.Parameters=_parameters0_0;
				//Inputs
				List<PropertyDescription> _inputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd1 = new PropertyDescription();
				pd1.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd1.PropertyName = "finalLeafNumber";
				pd1.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.finalLeafNumber)).ValueType.TypeForCurrentValue;
				pd1.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.finalLeafNumber);
				_inputs0_0.Add(pd1);
				PropertyDescription pd2 = new PropertyDescription();
				pd2.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd2.PropertyName = "leafNumber";
				pd2.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber)).ValueType.TypeForCurrentValue;
				pd2.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber);
				_inputs0_0.Add(pd2);
				PropertyDescription pd3 = new PropertyDescription();
				pd3.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd3.PropertyName = "previousLeafNumber";
				pd3.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber)).ValueType.TypeForCurrentValue;
				pd3.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber);
				_inputs0_0.Add(pd3);
				PropertyDescription pd4 = new PropertyDescription();
				pd4.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLAIState);
				pd4.PropertyName = "newLeafHasAppeared";
				pd4.PropertyType = (( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared)).ValueType.TypeForCurrentValue;
				pd4.PropertyVarInfo =( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared);
				_inputs0_0.Add(pd4);
				mo0_0.Inputs=_inputs0_0;
				//Outputs
				List<PropertyDescription> _outputs0_0 = new List<PropertyDescription>();
				PropertyDescription pd5 = new PropertyDescription();
				pd5.DomainClassType = typeof(SiriusQualityMaizeLAI.MaizeLeafState);
				pd5.PropertyName = "fracPopn";
				pd5.PropertyType =  (( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn)).ValueType.TypeForCurrentValue;
				pd5.PropertyVarInfo =(  SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn);
				_outputs0_0.Add(pd5);
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
				get { return "Decimal part of the haun stage for the final leaf. Unity for other leaves"; }
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
                
       
			}

			//Parameters static VarInfo list 
								
			
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
					
					SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn.CurrentValue=maizeleafstate.fracPopn;
					
					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();            
					
					
					RangeBasedCondition r5 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn);
					if(r5.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLeafStateVarInfo.fracPopn.ValueType)){prc.AddCondition(r5);}

					

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
					
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.finalLeafNumber.CurrentValue=maizelaistate.finalLeafNumber;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber.CurrentValue=maizelaistate.leafNumber;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber.CurrentValue=maizelaistate.previousLeafNumber;
					SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared.CurrentValue=maizelaistate.newLeafHasAppeared;

					//Create the collection of the conditions to test
					ConditionsCollection prc = new ConditionsCollection();
					Preconditions pre = new Preconditions();
            
					
					RangeBasedCondition r1 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.finalLeafNumber);
					if(r1.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.finalLeafNumber.ValueType)){prc.AddCondition(r1);}
					RangeBasedCondition r2 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber);
					if(r2.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.leafNumber.ValueType)){prc.AddCondition(r2);}
					RangeBasedCondition r3 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber);
					if(r3.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.previousLeafNumber.ValueType)){prc.AddCondition(r3);}
					RangeBasedCondition r4 = new RangeBasedCondition(SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared);
					if(r4.ApplicableVarInfoValueTypes.Contains( SiriusQualityMaizeLAI.MaizeLAIStateVarInfo.newLeafHasAppeared.ValueType)){prc.AddCondition(r4);}

					

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


                        if (index < Math.Floor(maizelaistate.finalLeafNumber))
                        {
                            maizeleafstate.fracPopn[index] = 1.0;
                        }
                        else
                        {
                            maizeleafstate.fracPopn[index] = maizelaistate.finalLeafNumber - Math.Floor(maizelaistate.finalLeafNumber);
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
