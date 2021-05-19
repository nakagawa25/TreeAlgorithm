using System;
using System.Collections.Generic;

namespace TestDev_Paradigma.Tools
{
    internal static class VisualTools
    {
        internal static string TakeArrayVisualString(List<int> array)
        {
            if (array.Count <= 0)
                return string.Empty;
            string arrayToReturn = string.Empty;
            foreach (int arrayItem in array)
                arrayToReturn += $"{arrayItem} - ";
            return arrayToReturn.Substring(0, arrayToReturn.Length - 3);
        }

        internal static string DrawTree(Model.Root treeRoot)
        {
            string draw = string.Empty;
            draw += "Raiz: " + treeRoot.RootValue + Environment.NewLine;

            draw += "Galhos da Esquerda: ";
            foreach (int leftArrayItem in treeRoot.LeftBranch)
                draw += $"{leftArrayItem}, ";
            draw = draw.Substring(0, draw.Length - 2) + Environment.NewLine;

            draw += "Galhos da Direita: ";
            foreach (int rightArrayItem in treeRoot.RightBranch)
                draw += $"{rightArrayItem}, ";
            draw = draw.Substring(0, draw.Length - 2);

            return draw;
        }
    }
}
