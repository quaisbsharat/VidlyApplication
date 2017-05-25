﻿using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        public short SignUpFee { get; set; } // سعر التسجيل في العضويه

        public byte DurationInMonth { get; set; }

        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;
    }
}