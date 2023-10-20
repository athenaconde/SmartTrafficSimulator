using STLS.Contracts;
using STLS.Model;
using STLS.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace STLS.ViewModel
{
   public class TrafficMonitoringViewModel : ViewModelBase, ITrafficMonitoring
    {
        //private TrafficLight _trafficLight1;
        //private TrafficLight _trafficLight2;
        //private TrafficLight _trafficLight3;
        //private TrafficLight _trafficLight4;

        private readonly List<TrafficLight> _trafficLights;
        private readonly TrialViewModel _trialVM;
        private bool _smartTrafficActivated;
        public TrafficMonitoringViewModel()
        {
            _trafficLights = new List<TrafficLight>();
            _trialVM = new Test.TrialViewModel();
            Car = new Car() { Speed = 3 };
        }

        //public TrafficLight TrafficLight1
        //{
        //    get { return _trafficLight1;}
        //    set {
        //        if (value != _trafficLight1)
        //        {
        //            _trafficLight1 = value;
        //            RaisePropertyChanged("TrafficLight1");
        //        }

        //    } }
        //public TrafficLight TrafficLight2
        //{
        //    get { return _trafficLight2; }
        //    set
        //    {
        //        if (value != _trafficLight2)
        //        {
        //            _trafficLight2 = value;
        //            RaisePropertyChanged("TrafficLight2");
        //        }

        //    }
        //}
        //public TrafficLight TrafficLight3
        //{
        //    get { return _trafficLight3; }
        //    set
        //    {
        //        if (value != _trafficLight3)
        //        {
        //            _trafficLight3 = value;
        //            RaisePropertyChanged("TrafficLight3");
        //        }

        //    }
        //}
        //public TrafficLight TrafficLight4
        //{
        //    get { return _trafficLight4; }
        //    set
        //    {
        //        if (value != _trafficLight4)
        //        {
        //            _trafficLight4 = value;
        //            RaisePropertyChanged("TrafficLight4");
        //        }

        //    }
        //}
        public Car Car { get; set; }
        public bool SmartTrafficActivated
        {
            get { return _smartTrafficActivated; }
            set
            {
                if (value != _smartTrafficActivated)
                {
                    _smartTrafficActivated = value;
                    RaisePropertyChanged("SmartTrafficActivated");
                }
            }
        }
        public List<TrafficLight> TrafficLights
        {
            get
            {
                this.Start();
                return _trafficLights;
            }
        }

        public List<Test.Trial> SimulatorTrials { get; set; }

        public void Start()
        {
            //this.TrafficLight1 = new TrafficLight() { IsStop = true };
            //this.TrafficLight2 = new TrafficLight() { IsStop = true };
            //this.TrafficLight3 = new TrafficLight() { IsStop = true };
            //this.TrafficLight4 = new TrafficLight() { IsStop = true };
            if (_trafficLights.Count == 0)
            {
                _trafficLights.Add(new TrafficLight { IsStop = true });
                _trafficLights.Add(new TrafficLight { IsStop = true });
                _trafficLights.Add(new TrafficLight { IsStop = true });
                _trafficLights.Add(new TrafficLight { IsStop = true });
            }
        }

        public void Trial(int id)
        {
            switch (id)
            {
                case 1:
                    SimulatorTrials = _trialVM.GetTrial1();
                    break;
                case 2:
                    SimulatorTrials = _trialVM.GetTrial2();
                    break;
                case 3:
                    SimulatorTrials = _trialVM.GetTrial3();
                    break;
                default:
                    break;
            }
            this.RaisePropertyChanged("SimulatorTrials");
        }
    }
}
