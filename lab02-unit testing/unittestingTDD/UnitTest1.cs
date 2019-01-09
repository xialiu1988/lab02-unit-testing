using System;
using Xunit;
using lab02_unit_testing;
namespace unittestingTDD
{
    public class UnitTest1
    {
        [Fact]

        public void canreturn()
        {
            Decimal balance = 5000;
            Decimal input = 32;
            Assert.Equal(5032, Program.DoDeposit(balance,input));

        }
        [Fact]

        public void cannotdonegtivedeposite()
        {
            Decimal balance = 5000;
            Decimal input = -32;
            Assert.Equal(5000, Program.DoDeposit(balance, input));

        }
    }
}
