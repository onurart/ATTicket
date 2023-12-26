using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Domain.AppEntites
{
    public class Error
    {
        public int Id { get; set; }
        public string Values { get; set; }
        public DateTime Created { get; set; }
    }
}
