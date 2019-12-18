using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace AssemblyLoader
{
    public class AssemblyLoaderInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "AssemblyLoader";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("4011bfa7-ff50-4ed4-9da7-a51785693783");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
