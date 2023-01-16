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
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate   { get; set; }
        // update zamani ver' tabanin ilk eklendiginde null olmasi lazim bu  yuzden nunable bir ifade icin soru isareti koyduk

    }
}
