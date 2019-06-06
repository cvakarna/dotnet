using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.University
{
    public interface IUniversity
    {
        Task<string> FreeSeat(int rank);
    }
}
