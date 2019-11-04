using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trady.Models
{
    public class InquiryEntity
    {
        [PrimaryKey]
        public int InquiryID { get; set; }
        public string InquiryName { get; set; }
        public string InquiryDate { get; set; }
        public string InquiryDetail { get; set; }
        public string InquiryImage { get; set; }
    }
}
