using System.Collections.Generic;

namespace TestDev_Paradigma.Model
{
    internal class Root
    {
        internal Root()
        {
            LeftBranch = new List<int>();
            RightBranch = new List<int>();
        }

        internal int ArrayIndex { get; set; }
        internal int RootValue { get; set; }
        internal List<int> LeftBranch { get; set; }
        internal List<int> RightBranch { get; set; }
    }
}