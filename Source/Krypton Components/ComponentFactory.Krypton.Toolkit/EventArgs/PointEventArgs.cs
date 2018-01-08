﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.6.2.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Drawing;

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
    /// Details for an event that provides a Point value.
	/// </summary>
    public class PointEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PointEventArgs class.
		/// </summary>
        /// <param name="point">Point associated with event.</param>
        public PointEventArgs(Point point)
		{
            Point = point;
		}
		#endregion

        #region Point
        /// <summary>
		/// Gets and sets the point.
		/// </summary>
        public Point Point { get; set; }

	    #endregion
    }
}
