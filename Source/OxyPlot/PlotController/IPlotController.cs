// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPlotController.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Specifies functionality to interact with a plot view.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot
{
    /// <summary>
    /// Specifies functionality to interact with a plot view.
    /// </summary>
    public interface IPlotController : IController
    {
        /// <summary>
        /// 小数据模式标记
        /// </summary>
        bool ISmall { get; set; }
    }
}
