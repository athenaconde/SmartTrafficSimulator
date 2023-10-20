using STLS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace STLS.Model
{
  public abstract  class Vehicle : IVehicle
    {

        public DirectionEnum Direction { get; set; }
        public int Speed { get; set; }
        public Brush Color { get; set; }

        public abstract Task Go(int speed);
        public abstract Task Slow();
        public abstract Task Stop();
    }
}
