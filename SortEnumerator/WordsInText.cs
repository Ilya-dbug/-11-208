using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEnumerator
{
    internal class WordsInText : IEnumerable<string>
    {
        public string[] words;
        public SortWords sortwords;
        public WordsInText(string text)
        {
            words = text.Split(' ');
            sortwords = new SortWords(words);
            sortwords.GetSorted();
        }
        public IEnumerator<string> GetEnumerator()
        {
            return new MyClass(words);

        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
