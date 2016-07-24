using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCar
{
   public class Made
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
