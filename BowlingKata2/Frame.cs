using System.Runtime.Serialization;

namespace BowlingKata2
{
	public class Frame
	{
		private readonly IList<Roll> rolls;

		public int Total => rolls.Sum(r => r.PinsDown);

		public Frame()
		{
			this.rolls = new List<Roll>();
		}
		private Frame(params Roll[] rolls)
		{
			this.rolls = new List<Roll>();
			foreach (Roll roll in rolls)
			{
				this.rolls.Add(roll);
			}
		}
		public static Frame Strike() => new Frame(new Strike());
		public static Frame Spare(int pinsDownRoll1, int pinsDownRoll2) => new Frame(new Roll(pinsDownRoll1), new Spare(pinsDownRoll2));

		public void Add(Roll roll) => rolls.Add(roll);
	}
}
