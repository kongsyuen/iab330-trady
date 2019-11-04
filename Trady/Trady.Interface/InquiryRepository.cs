using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trady.Models;

namespace Trady.Interface
{
    public interface InquiryRepository : IRepository<InquiryEntity>
    {
        InquiryEntity Get(int id);
    }

}