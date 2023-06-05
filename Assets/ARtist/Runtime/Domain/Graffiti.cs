using System.Collections;
using System.Collections.Generic;

namespace IMoreno.ARTist.Runtime.Domain
{
    public class Graffiti : IEnumerable<Line>
    {
        readonly Queue<Line> lines = new Queue<Line>();

        public void Add(Line theLine) => lines.Enqueue(theLine);

        public IEnumerator<Line> GetEnumerator() => lines.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}