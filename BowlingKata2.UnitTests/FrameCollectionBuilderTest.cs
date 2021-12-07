using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingKata2.UnitTests
{
	[TestClass]
	public class FrameCollectionBuilderTest
	{
		private readonly FrameCollectionBuilder builder = new FrameCollectionBuilder();

		[DataRow("")]
		[DataRow(null)]
		[TestMethod]
		public void Build_PassInvalidString_ShouldThrowException(string invalidString)
		{
			Action action = () => builder.Build(invalidString);

			action.Should().Throw<ArgumentException>();
		}

		[DataRow("00 00 00 00")]
		[DataRow("10 00 X X")]
		[DataRow("12 22 X 2/")]
		[DataRow("X X X X")]
		[TestMethod]
		public void Build_PassValidString_ShouldBuildCollection(string validScore)
		{
			FrameCollection collection = builder.Build(validScore);
			
			collection.Should().NotBeNull();
			collection.Size.Should().Be(4);
		}
	}
}