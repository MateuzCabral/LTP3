using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileStream_CriarArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar arquivo
            FileStream fs = new FileStream("C:\\Users\\Sala\\Desktop\\arquivo.txt",FileMode.Create);
            fs.Close();
            Console.WriteLine("So sucesso");

            //Escrever no arquivo
            FileStream fs = new FileStream("C:\\Users\\Sala\\Desktop\\arquivo.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Olá, eu sei escrever em um arquivo");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.WriteLine("So sucesso");
            Console.ReadKey();

            //Ler o arquivo
            string dado;
            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
            using (StreamReader sr = new StreamReader(fs))
            {
                dado = sr.ReadToEnd();
            }
            Console.WriteLine(data);
            fs.Close();
            Console.ReadKey();

	    \\Sobreescrever no Arquivo
	    string file = "C:\\Users\\Sala\\Desktop\\arquivo.txt";
            int a, b, c;
            a = 100;
            b = 1;
            c = a+b;
            DateTime data = DateTime.Now;

            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(data);
            }

            Console.WriteLine("Salvo com Sucesso");
        }
    }
}