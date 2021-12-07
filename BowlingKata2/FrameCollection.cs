namespace BowlingKata2
{
	public class FrameCollection
	{
		private readonly LinkedList<Frame> frames;

		public int Size => frames.Count;

		public FrameCollection()
		{
			frames = new LinkedList<Frame>();
		}

		internal void Add(Frame frame)
		{
			frames.AddLast(frame);
		}
	}
}
