﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Moviely.Models
{
    public class MemberShipType
    {
        [Key]
        public byte Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public MemberShipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}
