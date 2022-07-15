using Xunit;
using ClassLibrary;
using System;

namespace TestProject
{

    public class ConsoleReaderTest
    {

        [Fact]
        public void Word()
        {
            var input = "Madhur";
            ConsoleReader obj = new ConsoleReader();
            var expected = obj.Run(input, DelegatesAssignment.OnWord, DelegatesAssignment.OnNumber, DelegatesAssignment.OnJunk);
            Assert.Equal("Word",expected);
        }

        [Fact]
        public void Integer()
        {
            var input = "12345";
            ConsoleReader obj = new ConsoleReader();
            var expected = obj.Run(input, DelegatesAssignment.OnWord, DelegatesAssignment.OnNumber, DelegatesAssignment.OnJunk);
            Assert.Equal("Integer", expected);
        }

        [Fact]
        public void Junk()
        {
            var input = "hshs@123";
            ConsoleReader obj = new ConsoleReader();
            var expected = obj.Run(input, DelegatesAssignment.OnWord, DelegatesAssignment.OnNumber, DelegatesAssignment.OnJunk);
            Assert.Equal("Junk", expected);
        }

        [Fact]
        public void Invalid()
        {
            var input = "";
            ConsoleReader obj = new ConsoleReader();
            var expected = obj.Run(input, DelegatesAssignment.OnWord, DelegatesAssignment.OnNumber, DelegatesAssignment.OnJunk);
            Assert.Equal("Invalid Input", expected);
        }
    }
}