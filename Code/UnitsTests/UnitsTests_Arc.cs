using System;
using Xunit;
using ClassLibrary1;

namespace UnitsTests
{
    public class UnitsTests_Arc
    {
        [Fact]
        public void Test1()
        {
            Arc alabasta = new Arc("Alabasta", "Dans le désert", new Image("sgd", "gsgs"));

            Assert.Equal(alabasta.Nom, "Alabasta");

        }
    }
}
