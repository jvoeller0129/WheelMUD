﻿// <auto-generated />
//-----------------------------------------------------------------------------
// <copyright file="PortalExitRecord.cs" company="WheelMUD Development Team">
//   Copyright (c) WheelMUD Development Team. See LICENSE.txt. This file is
//   subject to the Microsoft Public License. All other rights reserved.
// </copyright>
// <summary>
//   auto-generated by EntityRecord.cst on 7/7/2012 4:24:09 PM
// </summary>
//-----------------------------------------------------------------------------

namespace WheelMUD.Data.Entities
{
    /// <summary>Represents a single PortalExit row in the PortalExit table.</summary>
    public partial class PortalExitRecord
    {
        public virtual long ID { get; set; }
        public virtual long PortalID { get; set; }
        public virtual long RoomAID { get; set; }
        public virtual long RoomBID { get; set; }
    }
}