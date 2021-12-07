namespace BowlingKata2
{
	public class FrameCollectionBuilder
	{
		private readonly FrameParser frameParser;

		public FrameCollectionBuilder()
		{
			frameParser = new FrameParser();
		}
		public FrameCollection Build(string finalScore)
		{
			if (string.IsNullOrEmpty(finalScore))
			{
				throw new ArgumentException(nameof(finalScore));
			}

			return ParseString(finalScore.Split(" "));
		}
		private FrameCollection ParseString(string[] score)
		{
			FrameCollection collection = new FrameCollection();
			foreach (string frame in score)
			{
				collection.Add(this.frameParser.Parse(frame));
			}
			return collection;
		}
	}
}
