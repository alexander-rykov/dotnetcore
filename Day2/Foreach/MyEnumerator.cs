using System.Collections.Generic;

namespace Foreach
{
    public class MyClass
    {
        public IEnumerable<int> GetSequence()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }
    }
}
