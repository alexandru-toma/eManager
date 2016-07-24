using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCar
{
    public interface IMadeDatabaseSet
    {
         IQueryable<Car> Cars { get; }
         IQueryable<Made> Mades { get; }
    }
}
