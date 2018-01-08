﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.6.2.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
    /// <summary>
    /// Contains a global identifier that is unique among objects.
    /// </summary>
    public class GlobalId
    {
        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the GlobalId class.
        /// </summary>
        [System.Diagnostics.DebuggerStepThrough]
        public GlobalId()
        {
            // Assign the next global identifier
            Id = CommonHelper.NextId;
        }
        #endregion

        #region Id
        /// <summary>
        /// Gets the unique identifier of the object.
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; }

        #endregion
    }
}
