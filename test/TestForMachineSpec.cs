using Machine.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    public class TestForMachineSpec
    {
        private Establish context = () => { };

        It should_failed = () =>
        {
            Assert.IsFalse(true);
        };
    }
}
