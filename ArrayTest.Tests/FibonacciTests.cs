using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayTest.Tests
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(5,5)]
        [InlineData(6, 8)]
        [InlineData(0, 0)]
        public void FibIterTest(int iteration, int expected)
        {
            var result = arrayTest.Program.FibIter(iteration);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        public void FibRectTest(int iteration, int expected)
        {
            var result = arrayTest.Program.FibRec(iteration);
            Assert.Equal(expected, result);
        }
    }

}
