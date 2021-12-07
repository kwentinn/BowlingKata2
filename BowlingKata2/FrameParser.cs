namespace BowlingKata2
{
	public sealed class FrameParser
	{
		public Frame Parse(string frame)
		{
			if (frame.Length == 1 && frame.Equals("x", StringComparison.InvariantCultureIgnoreCase))
			{
				return Frame.Strike();
			}

			int previousPinsDown = 0;
			Frame result = new Frame();
			foreach (char ball in frame)
			{
				if (int.TryParse(ball.ToString(), out int pinsDown))
				{
					result.Add(new Roll(pinsDown));
					previousPinsDown = pinsDown;
					continue;
				}
				if (ball.Equals('/'))
				{
					result.Add(new Spare(10 - previousPinsDown));
				}
			}

			if (result.Total > 10)
			{
				throw new FrameParsingException(frame);
			}

			return result;
		}
	}
}
