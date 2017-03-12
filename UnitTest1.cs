using System;
using Xunit;

namespace dotnetElasticsearch
{
    public class PrimeServiceTest
    {

        private PrimeService _primeService = null;
        public PrimeServiceTest()
        {
            _primeService = new PrimeService();
        }


        [Fact]
        [Trait("Category", "cat1")]
        [Trait("Priority", "1")]
        public void Test1()
        {
            // var p = new PrimeService();

            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should be prime");
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }
    }


    public class PrimeService
    {
        public bool IsPrime(int candidate) 
        {
            if(candidate<2)
             return false;
            throw new NotImplementedException("Please create a test first");
        } 
    }

}
