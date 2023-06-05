using NUnit.Framework;
using FluentAssertions;

using IMoreno.ARTist.Runtime.Domain;

namespace IMoreno.ARTist.Tests.Editor
{
    public class GraffitiTests
    {
        [Test]
        public void Graffiti_contains_lines()
        {
            var sut = new Graffiti { Line.Empty };

            sut.Should().Contain(Line.Empty);
        }
    }
}