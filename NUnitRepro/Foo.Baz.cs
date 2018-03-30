namespace NUnitRepro
{
    using NUnit.Framework;

    public partial class Foo<T>
    {
        public class Baz
        {
            [Test]
            public void BazTest()
            {
            }
        }
    }
}