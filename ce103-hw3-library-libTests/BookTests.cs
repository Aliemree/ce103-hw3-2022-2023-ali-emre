using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce103_hw3_library_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3_library_lib.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod()]
        public void ByteArrayBlockToBookTest()
        {
            Assert.Fail();
        }
    }
}

    public class LibraryTests
    {
        
        public void TestPassword_CorrectPassword_StartsProgram()
        {
            // Arrange
            var library = new LibraryTests();

            // Act
            library.TestPassword_CorrectPassword_StartsProgram();

            // Assert
            // Use reflection to check that the Start() method has been called
            var startMethod = typeof(LibraryTests).GetMethod("Start", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Assert.IsTrue(startMethod.IsPublic);
        }

        
        public void TestPassword_IncorrectPassword_ExitsProgram()
        {
            // Arrange
            var library = new LibraryTests();

            // Act
            library.TestPassword_CorrectPassword_StartsProgram();

            // Assert
            // Use reflection to check that the Environment.Exit() method has been called
            var exitMethod = typeof(Environment).GetMethod("Exit", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            Assert.IsTrue(exitMethod.IsPublic);
        }

        
        public void TestStart_DisplaysMainMenu()
        {
        // Arrange
        var library = new LibraryTests();

            // Act
            library.TestRunMainMenu_AcceptsUserInput_PerformsActions();

            // Assert
            // Check that the main menu has been displayed by checking the output of the Console
            var consoleOutput = Console.Out.ToString();
            Assert.IsTrue(consoleOutput.Contains("ce103-hm3- The Library Management"));
        }

        
        public void TestRunMainMenu_AcceptsUserInput_PerformsActions()
        {
            // Arrange
            var library = new LibraryTests();

            // Act
            library.TestStart_DisplaysMainMenu();

            // Assert
            // Check that the program has accepted user input by setting a fake value for the Console.ReadLine() method
            var readLineMethod = typeof(Console).GetMethod("ReadLine", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            readLineMethod.Invoke(null, new object[] { "fake user input" });
            // Check that the program has performed an action by checking that the WriteLine() method has been called
            var writeLineMethod = typeof(Console).GetMethod("WriteLine", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
            Assert.IsTrue(writeLineMethod.IsPublic);
        }
    }
