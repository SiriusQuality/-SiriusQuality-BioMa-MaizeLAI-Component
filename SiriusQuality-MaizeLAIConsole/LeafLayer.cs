using System;
using System.Collections.Generic;

namespace SiriusQuality_MaizeLAIConsole
{
    public class LeafLayer // Storage class for leaf layers
    {

        #region fields

        /// <summary>Change of DM for current day</summary>
        public double DeltaDM { get; set; }

        ////<summary>Largest area actually achived by leaf Layer i, dimensionless</summary>
        public double MaxAI { get; set; }

        ///<summary>Current development state of this leaves Layer</summary>
        public LeafState State { get; private set; }

        //<summary>Leaf lamina Area Index of this Layer</summary>
        public double laminaAI;

        /// <summary>Increment of area index for current day, dimensionless</summary>
        public double DeltaAI { get; set; }

        ///<summary>Layer Green Area Index</summary>
        public double GAI { get { return laminaAI; } }

        public double length { get; set; }
        public double width { get; set; }
        public double area { get; set; }
        public double exposedArea { get; set; }
        public double age { get; set; }
        public double cumIntRad { get; set; }

        #endregion

        #region Constructors

        /// <summary>Initial constructor</summary>
        /// <param name="universe">The universe of this LeafLayer.</param>
        /// <param name="i">The index of this leaf Layer (0 based index, starts from the bottom of the plant).</param>
        public LeafLayer(double laminaspecificN, double TTatEmergence)
        {

            DeltaDM = 0.0;
            laminaAI = 0.0;
            State = LeafState.Growing;
            MaxAI = 0.0;
            DeltaAI = 0.0;
            length = 0.0;
            width = 0.0;
            area = 0.0;
            exposedArea = 0.0;
            age = 0.0;
            cumIntRad = 0.0;

        }

        ///<summary>Copy constructor</summary>
        ///<param name="universe">The universe of this leaf Layer.</param>
        ///<param name="toCopy">The leaf Layer to copy</param>
        public LeafLayer(LeafLayer toCopy)
        {
            DeltaDM = toCopy.DeltaDM;
            laminaAI = toCopy.laminaAI;
            State = toCopy.State;
            DeltaAI = toCopy.DeltaAI;
            length = toCopy.length;
            width = toCopy.width;
            area = toCopy.area;
            exposedArea = toCopy.exposedArea;
            age = toCopy.age;
            cumIntRad = toCopy.cumIntRad;
            MaxAI = toCopy.MaxAI;
        }

        #endregion

        #region Utilities

        public void setState(LeafState newState)
        {
            State = newState;
        }


        #endregion



    }
}