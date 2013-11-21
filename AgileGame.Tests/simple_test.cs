using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace AgileGame.Tests
{
    [TestFixture]
    public class simple_test
    {
        [Test]
        public void calc_2_plus_3()
        {
            var num1 = 2;
            var num2 = 3;
            var results = num1 + num2;
            results.Should().Be(5);
        }
    }
}
