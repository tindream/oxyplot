// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OxyMouseGesture.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Represents a mouse input gesture.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot
{
    /// <summary>
    /// Represents a mouse input gesture.
    /// </summary>
    /// <remarks>The input gesture can be bound to a command in a <see cref="PlotController" />.</remarks>
    public class OxyMouseMoveGesture : OxyInputGesture
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OxyMouseMoveGesture" /> class.
        /// </summary>
        public OxyMouseMoveGesture()
        {
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns><c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <c>false</c>.</returns>
        public override bool Equals(OxyInputGesture other)
        {
            var mg = other as OxyMouseMoveGesture;
            return mg != null;
        }
    }
}
