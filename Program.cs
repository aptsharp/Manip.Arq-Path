using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string arq = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(arq)); // pega somente a pasta
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // mostra o caracter de separação "/" se fosse linux seria "\"
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // caracter de separação 
            Console.WriteLine("GetFileName: " + Path.GetFileName(arq));//para pegar o nome do arquivo com a extenção
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(arq)); //pega somente a extenção do arquivo
            Console.WriteLine("GetExtension: " + Path.GetExtension(arq));//pega somente a extenção do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(arq));//pega o caminho do arquivo com o nome do arquivo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());//exibe a pasta temporaria do sistema



        }
    }
}
