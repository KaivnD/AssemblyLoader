using Grasshopper.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyLoader
{
    public class ALoader : GH_AssemblyPriority
    {
        public override GH_LoadingInstruction PriorityLoad()
        {
            string refdll = @"D:\Desktop\KVDT\KVDT\bin\Debug\KVDT.dll";
            Assembly.LoadFrom(refdll);
            return GH_LoadingInstruction.Proceed;
        }
    }
}
