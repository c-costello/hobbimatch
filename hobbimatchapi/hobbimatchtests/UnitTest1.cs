using System;
using Xunit;

namespace hobbimatchtests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int x = 4;
            Assert.Equal(4, x);
        }
    }
}
