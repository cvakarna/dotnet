using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.University
{
    public abstract class UniversityFactory
    {
        public abstract IUniversity Create();
    }
}
