using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
    {
        //Classlarımız icin ortak propertylerimizi tanımladık
        public int ID { get; set; }
        public DateTime CreatedTime   { get; set; }
        public DateTime UpdatedTime   { get; set; }

    }
}
