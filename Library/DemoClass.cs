using System.Collections.Generic;

namespace MyDemoSharedLibrary
{
    public class DemoClass
    {
        public IEnumerable<string> GetSomeSampleData()
        {
            yield return "Hello";
            yield return "my";
            yield return "friends";
            yield return "enjoy";
            yield return "this";
            yield return "sample";
            yield return "text";
        }
    }
}
