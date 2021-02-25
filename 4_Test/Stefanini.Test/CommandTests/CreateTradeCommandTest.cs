using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stefanini.Domain.DemoContext.Commands.Inputs;

namespace Stefanini.Test.CommandTests
{

    [TestClass]
    public class CreateTradeCommandTest
    {
        private readonly TradeCommand _invalidCommand = new TradeCommand(0, null);
        private readonly TradeCommand _validCommand = new TradeCommand(10000, "Public");

        public CreateTradeCommandTest()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        //RED GREEN REFACTOR
        [TestMethod]
        public void DadoCommandoInvalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void DadoCommandovalido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }

    }
}