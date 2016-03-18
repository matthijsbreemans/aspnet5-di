using DIShowcase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIShowcase.Services
{
    public class SampleService : ISampleService
    {
        private Guid guid;
        public SampleService()
        {
            guid = Guid.NewGuid();
        }
        public string HelloWorld()
        {
            return "HelloWorld! " + guid;
        }
    }
}
