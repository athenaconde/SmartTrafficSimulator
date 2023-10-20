using System.Collections.Generic;

namespace STLS.Test
{
    public class TrialViewModel
    {
        public List<Trial> GetTrial1()
        {
            var routes = new List<Trial>();
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Blue), NumberOfVehicle = 67, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Red), NumberOfVehicle = 74, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Green), NumberOfVehicle = 52, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yello), NumberOfVehicle = 44, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yellow_left), NumberOfVehicle = 50, });
            return routes;
        }

        public List<Trial> GetTrial2()
        {
            var routes = new List<Trial>();
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Blue), NumberOfVehicle = 69, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Red), NumberOfVehicle = 73, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Green), NumberOfVehicle = 49, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yello), NumberOfVehicle = 48, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yellow_left), NumberOfVehicle = 53, });
            return routes;
        }

        public List<Trial> GetTrial3()
        {
            var routes = new List<Trial>();
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Blue), NumberOfVehicle = 71, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Red), NumberOfVehicle = 66, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Green), NumberOfVehicle = 49, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yello), NumberOfVehicle = 49, });
            routes.Add(new Trial() { Route = getRoute(RouteEnum.Yellow_left), NumberOfVehicle = 50, });
            return routes;
        }

        private RouteTrafficLightTime getRoute(RouteEnum route)
        {
            switch (route)
            {
                case RouteEnum.Blue:
                    return new RouteTrafficLightTime() { Route = RouteEnum.Blue, GoTicksInSeconds = 70, StopTicksInSeconds = 170 };
                case RouteEnum.Red:
                    return new RouteTrafficLightTime() { Route = RouteEnum.Red, GoTicksInSeconds = 96, StopTicksInSeconds = 145 };
                case RouteEnum.Green:
                   return new RouteTrafficLightTime() { Route = RouteEnum.Green, GoTicksInSeconds = 135, StopTicksInSeconds = 145 };
                case RouteEnum.Yello:
                    return new RouteTrafficLightTime() { Route = RouteEnum.Yello, GoTicksInSeconds = 80, StopTicksInSeconds = 175 };
                case RouteEnum.Yellow_left:
                   return new RouteTrafficLightTime() { Route = RouteEnum.Yellow_left, GoTicksInSeconds = 130, StopTicksInSeconds = 100 };
                default:
                    return null;
            }
        }
    }

    public class Trial
    {

        public RouteTrafficLightTime Route { get; set; }
        public int NumberOfVehicle { get; set; }
    }

    public class RouteTrafficLightTime
    {
        public RouteEnum Route { get; set; }
        public int GoTicksInSeconds { get; set; }
        public int StopTicksInSeconds { get; set; }
    }

    public enum RouteEnum
    {
        Blue,
        Red,
        Green,
        Yello,
        Yellow_left
    }
}
