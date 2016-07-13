using System.Collections;

namespace Foreach
{
    public class AnotherClass
    {
        public IEnumerator GetEnumerator()
        {
            var arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i;
            }
            return arr.GetEnumerator();
        }
    }
}
