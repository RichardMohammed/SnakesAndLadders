using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class DiceTest
    {
        public readonly ITestOutputHelper _output;
        public DiceTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Dice_Roll_Returns_Between_1And6()
        {
            for (int i = 0; i < 50; i++)
            {
                var num = Dice.Instance.Roll();

                Assert.True(num > 0);
                Assert.True(num < 7);
                _output.WriteLine(num.ToString());
            }
        }
    }
}
