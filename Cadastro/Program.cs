using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlPessoa pessoa = new ControlPessoa();//Conectando as duas classes: Control e Model
            pessoa.Operacao();
            Console.ReadLine();//Manter o prompt aberto
        }//fim do método
    }//fim da classe
}//fim do projeto
