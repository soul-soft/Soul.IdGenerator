namespace Soul.IdGenerator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var num = SnowflakeGenerator.Generate(1);
        }
    }
}