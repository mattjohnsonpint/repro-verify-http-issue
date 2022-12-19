using BaseLibrary;

namespace TestProject;

[Collection("Tests")]
public class UnitTest2 : TestBaseClass
{
    [Fact]
    public void Test2()
    {
        DoSomething();
    }
}