using Xunit;
using ClassLibrary;
using System;

namespace TestProject
{

    public class ConsoleReaderTest
    {

        ConsoleReader obj = new ConsoleReader();
        [Fact]
        public void Test()
        {
            Assert.Equal("Madhur", obj.Run("Madhur", Delegates.OnWord, Delegates.OnNumber, Delegates.OnJunk));
        }

    }
}