using STLS.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Model
{
    public class TrafficLight : ModelBase, ITrafficLight
    {
        private bool _isGo;
        private bool _isWarning;
        private bool _isStop;

        public bool IsGo { get { return _isGo; }
            set
            {
                if (value == true)
                {
                    this.IsStop = false;
                    this.IsWarning = false;
                }
                _isGo = value;
                this.RaisePropertyChanged("IsGo");
            }
        }
        public bool IsWarning
        {
            get { return _isWarning; }
            set
            {
                if (value == true)
                {
                    IsGo = false;
                    IsStop = false;
                }
                _isWarning = value;
                this.RaisePropertyChanged("IsWarning");
            }
        }
        public bool IsStop
        {
            get { return _isStop; }
            set
            {
                if (value == true)
                {
                    IsGo = false;
                    IsWarning = false;
                }
                _isStop = value;
                this.RaisePropertyChanged("IsStop");
            }
        }
        public Task<T> Tick<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
