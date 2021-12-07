namespace BowlingKata2
{
	public record Roll
	{
		public int PinsDown { get; }

		public Roll(int pinsDown)
		{
			PinsDown = pinsDown;
		}
	}
}
