using Machine.Specifications;

namespace test
{
    public class TestForMachineSpec
    {
        private Establish context = () => { };

        It should_pass_1 = () =>
        {
            false.ShouldBeFalse();
        };
    }
}
