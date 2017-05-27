using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? BirthDate { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}