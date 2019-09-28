using SQLite;

namespace Trady.Models
{
    public class Inquiries
    {
        [PrimaryKey, AutoIncrement]
        public int InquiryID { get; set; }
        public string InquiryName { get; set; }
        public string InquiryDate { get; set; }
        public string InquiryDetail { get; set; }
        public string InquiryImage { get; set; }
    }
}
