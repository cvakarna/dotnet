using FactoryMethodDemo.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.University
{
    public class UniversityProvider
    {
        private readonly IDictionary<Universities, UniversityFactory> _factories;
        public UniversityProvider()
        {
            _factories = new Dictionary<Universities, UniversityFactory>();

            foreach (Universities university in Enum.GetValues(typeof(Universities)))
            {
                string name = "FactoryMethodDemo.University.Factory." + Enum.GetName(typeof(Universities), university) + "Factory";
                var factory = (UniversityFactory)Activator.CreateInstance(Type.GetType(name));
                _factories.Add(university, factory);
            }

        }

        public IUniversity ExecuteCreation(Universities university)
        {
            return _factories[university].Create();
        }
    }
}
