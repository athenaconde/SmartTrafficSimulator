using STLS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Model
{
    public class InfraredSensor : IInfraredSensor
    {
        public Task Activate()
        {
            throw new NotImplementedException();
        }

        public Task Deactivate()
        {
            throw new NotImplementedException();
        }

        public Task MotionDetected()
        {
            throw new NotImplementedException();
        }
    }
}
