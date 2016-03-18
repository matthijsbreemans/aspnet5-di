using DIShowcase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIShowcase.Services
{
    public class SampleSingleton : ISampleSingleton
    {
        private Guid guid;

        public SampleSingleton()
        {
            guid = Guid.NewGuid();
        }
        public string HelloSingleton()
        {
            return "HelloSingleton " + guid;
        }
    }
}
