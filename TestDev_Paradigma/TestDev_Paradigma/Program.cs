using System;
using System.Collections.Generic;

namespace TestDev_Paradigma
{
    class Program
    {
        private static Controller.TreeController tree;
        private static List<int> array;
        static void Main(string[] args)
        {
            try
            {
                tree = new Controller.TreeController();
                array = new List<int>();

                StartArrayInput();
                PrintTree();
            }
            catch (Exception error)
            {
                Console.WriteLine("Ocorreu um erro na execução do programa. Erro: " + error.Message);
            }
            Console.WriteLine("Digite qualquer tecla para sair.");
            Console.ReadLine();
        }

        private static void StartArrayInput()
        {
            bool arrayInsertion = true;
            while (arrayInsertion)
            {
                Console.WriteLine("Digite o próximo número do array (ou S para sair/finalizar): ");
                string keyboardInput = Console.ReadLine();
                if (keyboardInput.ToUpper() == "S")
                {
                    arrayInsertion = false;
                    break;
                }
                else
                {
                    int nextValue = 0;
                    if (int.TryParse(keyboardInput, out nextValue))
                    {
                        if (Tools.ValidationTools.VerifyDuplicityInArray(array, nextValue))
                            array.Add(nextValue);
                        else
                            Console.WriteLine("O Array não pode possuir valores duplicados, favor inserir outro valor. ");
                    }
                    else
                        Console.WriteLine("O valor digitado não pode ser inserido no Array, favor inserir um valor inteiro válido. ");
                }
                PrintArray();
            }
        }

        private static void PrintTree()
        {
            Console.Clear();
            Model.Root treeRoot = tree.GetTree(array);
            Console.WriteLine($"Array de Entrada: [{Tools.VisualTools.TakeArrayVisualString(array)}]");
            Console.WriteLine(Tools.VisualTools.DrawTree(treeRoot));
        }

        private static void PrintArray()
        {
            Console.WriteLine("Array Atual: " + Tools.VisualTools.TakeArrayVisualString(array));
        }
    }
}
