namespace TestProject;

[UsesVerify]
[Collection("Tests")]
public class UnitTest1
{
    [Fact]
    public Task Test1()
    {
        return Verify("abc123");
    }
}