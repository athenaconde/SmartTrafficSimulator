using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Contracts
{
   public interface IInfraredSensor
    {
        Task Activate();
        Task Deactivate();
        Task MotionDetected();
    }
}
