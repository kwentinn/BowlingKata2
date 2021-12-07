namespace BowlingKata2
{
	[Serializable]
	public class FrameParsingException : Exception
	{
		public FrameParsingException(string? message) : base(message)
		{
		}
	}
}
