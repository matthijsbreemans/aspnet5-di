using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIShowcase.Interfaces;

namespace DIShowcase.Services
{
    public class SampleTransient
    {

        public ISampleRequest sampleRequest { get; set; }
        public ISampleService sampleService { get; set; }
        public SampleWithoutInterface sampleWithoutInterface { get; set; }


        public SampleTransient(ISampleRequest sampleRequest, ISampleService sampleService, SampleWithoutInterface sampleWithoutInterface)
        {
            this.sampleRequest = sampleRequest;

            this.sampleService = sampleService;

            this.sampleWithoutInterface = sampleWithoutInterface;
        }

    }
}
