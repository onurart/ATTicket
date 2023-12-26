using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Domain.Abstractions
{
    public abstract class Entity
    {
        public Entity()
        {
        }
        public Entity(string id)
        {
            Id = id;
        }
        public string Id { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; }
        public DateTime DeleteDate { get; set; }



    }
}
