using CargoTrack.Entity.Common;
using CargoTrack.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CargoTrack.Entity.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = null!;
        public int PlateCode { get; set; } 
        public Region Region { get; set; } 
    }
}
