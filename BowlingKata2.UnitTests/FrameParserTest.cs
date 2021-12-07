using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingKata2.UnitTests
{
	[TestClass]
	public class FrameParserTest
	{
		[TestMethod]
		public void Parse_PassTwoNormalRolls_ShouldReturnNewFrame()
		{
			string input = "12";
			FrameParser parser = new FrameParser();
			Frame actualFrame = parser.Parse(input);

			actualFrame.Should().NotBeNull();
		}
		[TestMethod]
		public void Parse_PassStrikeRoll_ShouldReturnNewFrame()
		{
			string input = "X";
			FrameParser parser = new FrameParser();

			Frame actualFrame = parser.Parse(input);

			actualFrame.Should().NotBeNull();
			actualFrame.Total.Should().Be(10);
		}
		[TestMethod]
		public void Parse_Pass3AndSpareRoll_ShouldReturnNewFrame()
		{
			string input = "3/";
			FrameParser parser = new FrameParser();

			Frame actualFrame = parser.Parse(input);

			actualFrame.Should().NotBeNull();
			actualFrame.Total.Should().Be(10);
		}
		[TestMethod]
		public void Parse_PassTwoRollsExceedingTen_ShouldThrowException()
		{
			string input = "58";
			FrameParser parser = new FrameParser();

			Action action = () => parser.Parse(input);

			action.Should().ThrowExactly<FrameParsingException>();
		}
	}
}