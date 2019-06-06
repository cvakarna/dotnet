using FactoryMethodDemo.University;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo.Repository
{
    public class IITDelhi : IUniversity
    {
        private readonly int _cutoff;
        public IITDelhi()
        {
            _cutoff = 50;
        }
        public Task<string> FreeSeat(int rank)
        {
            if (rank<=_cutoff)
            {
                return Task<string>.FromResult("Congratulations!!!");
            }
            else
            {
                return Task<string>.FromResult("Sorry!!!");
            }
        }
    }
}
