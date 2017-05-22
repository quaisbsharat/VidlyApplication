namespace VidlyThirdTime.Models
{
    public class MembershipType
    {
        //This is a Test for githup
        public byte Id { get; set; }
        public short SignUpFee { get; set; } // سعر التسجيل في العضويه
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}