using Machine.Specifications;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    public class TestForMachineSpec
    {
        private Establish context = () => { };

        It should_pass_1 = () =>
        {
            Assert.IsFalse(false);
        };
    }
}
