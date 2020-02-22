﻿//-----------------------------------------------------------------------------
// <copyright file="AreaRecord.NoGen.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    using System.Collections.Generic;

    /// <summary>Custom code for the AreaRecord class.</summary>
    public partial class AreaRecord
    {
        /// <summary>Initializes a new instance of the AreaRecord class.</summary>
        public AreaRecord()
        {
            this.Rooms = new Dictionary<long, RoomRecord>();
        }

        /// <summary>Gets or sets the rooms within the area.</summary>
        public virtual Dictionary<long, RoomRecord> Rooms { get; set; }
    }
}