using System;
using System.Threading;
using System.Diagnostics;
using Xunit;

namespace dotnetElasticsearch
{

    [Collection("Test smaple")]
    public class Test1
    {


        [Fact, Trait("Category","Integration")]
        public void SlowTest()
        {
            Thread.Sleep(5000);
            Debug.WriteLine("slow test executed");
            Assert.True(true);
        }
    }


}
