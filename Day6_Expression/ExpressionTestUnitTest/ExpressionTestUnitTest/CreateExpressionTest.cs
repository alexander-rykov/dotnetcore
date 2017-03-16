using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace Sample02
{
    [TestClass]
    public class CreateExpressionTest
    {
        [TestMethod]
        public void FromLambda()
        {
            Expression<Func<int>> exp1 = () => 1 + 3 * 5;
            Expression<Func<int, double>> exp2 = (x) => (int)(Math.PI * x);
            Expression<Func<object>> exp3 = () => new { Name = "Alex", Age = 17 };

            Console.WriteLine(exp1);
            Console.WriteLine(exp2);
            Console.WriteLine(exp3);
        }

        [TestMethod]
        public void Manualy()
        {
            var exp1 = Expression.Lambda();

            var xparam = Expression.Parameter(typeof(double), "x");

            var exp2 = Expression.Lambda();

            var obj = new { Name = "Alex", Age = 17 };

            var exp3 = Expression.Lambda();

            Assert.AreEqual("() => (1 + (3 * 5))", exp1.ToString());
            Assert.AreEqual("x => Convert((3,14159265358979 * x))", exp2.ToString());
            Assert.AreEqual("() => new <>f__AnonymousType0`2("Alex", 17)", exp3.ToString());
        }
    }
}
