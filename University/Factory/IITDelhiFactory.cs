using FactoryMethodDemo.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.University.Factory
{
    public class IITDelhiFactory : UniversityFactory
    {
        public override IUniversity Create() => new IITDelhi();
       
    }
}
