using System.Collections.Generic;
using System.Linq;

namespace TestDev_Paradigma.Controller
{
    internal class TreeController
    {
        private Model.Root TreeRoot { get; set; }

        internal TreeController()
        {
            TreeRoot = new Model.Root();
        }

        internal Model.Root GetTree(List<int> inputTree)
        {
            SetTreeRootValueAndIndex(inputTree);
            SetTreeBranches(inputTree);
            return TreeRoot;
        }

        private void SetTreeRootValueAndIndex(List<int> inputTree)
        {
            TreeRoot.RootValue = inputTree.Max();
            TreeRoot.ArrayIndex = inputTree.IndexOf(TreeRoot.RootValue);
        }

        private void SetTreeBranches(List<int> inputTree)
        {
            for (int i = 0; i < TreeRoot.ArrayIndex; i++)
                TreeRoot.LeftBranch.Add(inputTree[i]);
            TreeRoot.LeftBranch = TreeRoot.LeftBranch.OrderByDescending(i => i).ToList();

            for (int i = TreeRoot.ArrayIndex + 1; i < inputTree.Count; i++)
                TreeRoot.RightBranch.Add(inputTree[i]);
            TreeRoot.RightBranch = TreeRoot.RightBranch.OrderByDescending(i => i).ToList();
        }
    }
}
