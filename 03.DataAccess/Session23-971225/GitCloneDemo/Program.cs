using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCloneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"cd D:\Development\GitTest && git clone https://github.com/farhangv/pack-9710");
        }
    }
}
