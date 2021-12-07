namespace BowlingKata2
{
	public record Spare : Roll
	{
		public Spare(int pinsDown) : base(pinsDown) { }
	}
}
