﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a FloatspaceAdding/FloatspaceRemoved event.
	/// </summary>
	public class FloatspaceEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the FloatspaceEventArgs class.
		/// </summary>
        /// <param name="floatspace">Reference to new floatspace control instance.</param>
        /// <param name="element">Reference to docking floatspace element that is managing the floatspace control.</param>
        public FloatspaceEventArgs(KryptonFloatspace floatspace,
                                   KryptonDockingFloatspace element)
		{
            FloatspaceControl = floatspace;
            FloatspaceElement = element;
		}
        #endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonFloatspace control..
        /// </summary>
        public KryptonFloatspace FloatspaceControl { get; }

	    /// <summary>
        /// Gets a reference to the KryptonDockingFloatspace that is managing the space control.
        /// </summary>
        public KryptonDockingFloatspace FloatspaceElement { get; }

	    #endregion
	}
}