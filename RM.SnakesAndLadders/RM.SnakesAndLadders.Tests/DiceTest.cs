using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class DiceTest
    {
        public readonly ITestOutputHelper Output;
        public DiceTest(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void Dice_Roll_Returns_Between_1And6()
        {
            for (var i = 0; i < 50; i++)
            {
                var num = Dice.Instance.Roll();

                Assert.True(num > 0);
                Assert.True(num < 7);
                Output.WriteLine(num.ToString());
            }
        }

        [Fact]
        public void Dice_Roll_Consecutive_Rolls_Not_Same()
        {
            var rolls = Enumerable.Range(1, 6).Select(r => Dice.Instance.Roll()).ToList();
            Assert.True(rolls.Distinct().Count() > 1);

            Output.WriteLine($"{rolls[0].ToString()} {rolls[1].ToString()} {rolls[2].ToString()} {rolls[3].ToString()}");
        }

    }
}
