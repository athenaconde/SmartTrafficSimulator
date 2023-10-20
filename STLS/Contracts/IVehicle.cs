using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Contracts
{
   public interface IVehicle
    {
        Task Go(int speed);
        Task Slow();
        Task Stop();
    }
}
