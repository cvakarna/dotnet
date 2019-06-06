using FactoryMethodDemo.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.University.Factory
{
    public class AnnaUniversityFactory : UniversityFactory
    {
        public override IUniversity Create() => new AnnaUniversity();
       
    }
}
