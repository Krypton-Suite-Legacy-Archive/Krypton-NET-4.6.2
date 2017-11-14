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
using System.Xml;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event data for loading global docking configuration.
	/// </summary>
	public class DockGlobalLoadingEventArgs : EventArgs
	{
		#region Instance Fields

	    #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockGlobalLoadingEventArgs class.
		/// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlReading">Xml reader for persisting custom data.</param>
        public DockGlobalLoadingEventArgs(KryptonDockingManager manager,
                                          XmlReader xmlReading)
		{
            DockingManager = manager;
            XmlReader = xmlReading;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the docking manager reference.
		/// </summary>
        public KryptonDockingManager DockingManager { get; }

	    /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public XmlReader XmlReader { get; }

	    #endregion
	}
}