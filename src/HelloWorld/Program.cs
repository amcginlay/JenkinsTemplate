using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program(Console.Out).Start();
        }

        private System.IO.TextWriter textWriter;

        public Program(System.IO.TextWriter textWriter)
        {
            this.textWriter = textWriter;
        }

        public void Start()
        {
            textWriter.WriteLine("Hello, World!");
        }
    }
}
