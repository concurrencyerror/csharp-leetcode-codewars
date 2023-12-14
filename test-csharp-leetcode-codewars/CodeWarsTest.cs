namespace test_csharp_leetcode_codewars;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        char a = 'a';
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a);
            a++;
        }
        
    }
}