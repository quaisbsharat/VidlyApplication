using System.Collections.Generic;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> Memberships { get; set; }
        public Customer Customer { get; set; }

    }
}