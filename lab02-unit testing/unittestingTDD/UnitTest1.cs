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

        [Fact]
        public void candodeposite()
        {
            Decimal balance = 5000;
           Decimal input = 3.5m;
            Assert.Equal(5003.5m, Program.DoDeposit(balance, input));

        }


        [Fact]
        public void cannotdonegtivewithdraw()
        {
            Decimal balance = 5000;
            Decimal input = -3.5m;
            Assert.Equal(5000, Program.DoWithdraw(balance, input));

        }

        [Fact]
        public void cannotdowithdrawwithamountlargerthanyourbalance()
        {
            Decimal balance = 5000;
            Decimal input = 5000000;
            Assert.Equal(5000, Program.DoWithdraw(balance, input));

        }

        [Fact]
        public void candowithdraw()
        {
            Decimal balance = 5000;
            Decimal input = 399.5m;
            Assert.Equal(4600.5m, Program.DoWithdraw(balance, input));

        }



    }
}
