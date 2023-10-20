using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Model
{
    public class Car : Vehicle
    {
        public override async Task Go(int speed)
        {
          await Task.Run(()=>Speed = speed);
        }

        public override async Task Slow()
        {
            await Task.Run(() =>Speed = Speed / 2);
        }

        public override async Task Stop()
        {
            await Task.Run(()=> Speed = 0);
        }
    }
}
