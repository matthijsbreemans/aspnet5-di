using DIShowcase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIShowcase.Services
{
    public class SampleRequest : ISampleRequest
    {
        private Guid guid;
        public SampleRequest()
        {
            guid = Guid.NewGuid();
        }
        public string HelloRequest()
        {
            return "HelloRequest " + guid;
        }
    }
}
