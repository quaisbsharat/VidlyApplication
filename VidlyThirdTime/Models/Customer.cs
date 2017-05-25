using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsAMember]
        [Display(Name = "Birth of Date")]
        public DateTime? BirthDate { get; set; }

        //Navigation Property
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}