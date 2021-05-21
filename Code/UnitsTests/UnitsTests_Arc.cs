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
            Arc alabasta = new Arc(NomArc.Alabasta, "Dans le d�sert", new Image("sgd", "gsgs"));

            Assert.Equal(alabasta.Nom, NomArc.Alabasta);

        }
    }
}
