using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STLS.Contracts
{
   public interface ITrafficLight
    {
        Task<T> Tick<T>() where T : class;
        //Task<T> Stop<T>() where T : class;
        //Task<T> Go<T>() where T : class;
    }
}
