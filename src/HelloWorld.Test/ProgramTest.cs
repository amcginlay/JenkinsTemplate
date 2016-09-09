using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using HelloWorld;

namespace HelloWorld.Test
{
    [TestClass]
    public class ProgramTest
    {
        private class TestWriter : TextWriter
        {
            public String Value { get; private set; }

            public override System.Text.Encoding Encoding
            {
                get { return System.Text.Encoding.Unicode; }
            }

            public override void WriteLine(string value) {
                Value = value;
            }
        }
        
        [TestMethod]
        public void Test_Start_WriterObjectYieldsTextHelloWorld_WhenInvoked()
        {
            // arrange
            var textWriter = new TestWriter();
            var program = new Program(textWriter);
            // act
            program.Start();
            // assert
            Assert.AreEqual("Hello, World!", textWriter.Value);
        }
    }
}
