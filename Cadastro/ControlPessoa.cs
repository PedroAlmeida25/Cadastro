using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class ControlPessoa
    {
        private int opcao;
        DAO conectar;
        public int codigo;
        public ControlPessoa() 
        {
            //Instanciar uma variável = Determinar o valor inicial dela
            ConsultarOpcao = 0;
            conectar = new DAO();//Conectando ao Banco de Dados
        }//fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; } 
        }//fim do getSet
        
        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n"+
                             "1 Cadastrar\n" +
                             "2. Consultar\n" +
                             "3. Consultar Individual\n" +
                             "4. Atualizar\n" +
                             "5. Excluir\n" +
                             "6. Sair\n");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do menu

        public void Operacao()
        {
            do
            {
                Menu();//Mostrar as opções para o usuário
                switch (ConsultarOpcao)
                {
                    case 1:
                        Cadastrar();
                        break;
                    case 2:
                        ConsultarTudo();
                        break;
                    case 3:
                        ConsultarIndividual();
                        break;
                    case 4:
                        MenuAtualizar();    
                        break;
                    case 5:
                        Deletar();
                        break;
                    case 6:
                        Console.WriteLine("Obrigado!");
                        break;
                    default:
                        Console.WriteLine("Informe um código de acordo com o menu");
                        break;
                }//fim do escolha do caso
            } while (ConsultarOpcao != 6);

        }//fim do método
        public void Cadastrar() 
        {
            Console.WriteLine("Informe o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone da pessoa: ");
            string telefone = Console.ReadLine();
            Console.WriteLine("Informe a cidade da pessoa: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Informe o endereço da pessoa: ");
            string endereco = Console.ReadLine();
            conectar.Inserir(nome, telefone, cidade, endereco);
        }//fim do método Cadastrar

        public void ConsultarTudo()
        {
            Console.WriteLine(conectar.ConsultarTudo());    
        }//fim do consultarTudo

        public void ConsultarIndividual()
        {
            Console.WriteLine("Informe o código que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //Mostrar na tela
            Console.WriteLine(conectar.ConsultarTudo(codigo));
        }//fim do Consultar

        public void MostrarMenuAtualizar()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                             "\n1. Nome " +
                             "\n2. Telefone " +
                             "\n3. Cidade " +
                             "\n4. Endereço ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método


        public void MenuAtualizar()
        {
            int opcao = 0;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o código do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo nome: ");
                    string nome = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "nome", nome));
                    break;
                case 2:
                    Console.WriteLine("Informe o código do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo telefone: ");
                    string telefone = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "telefone", telefone));
                    break;
                case 3:
                    Console.WriteLine("Informe o código do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a nova cidade: ");
                    string cidade = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "cidade", cidade));
                    break;
                case 4:
                    Console.WriteLine("Informe o código do dado que deseja atualizar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo endereco: ");
                    string endereco = Console.ReadLine();
                    //Método que deseja atualizar
                    Console.WriteLine("\n\n" + conectar.Atualizar(codigo, "endereco", endereco));
                    break;
                default:
                    Console.WriteLine("Opção escolhida não é válida!");
                    break;
            }//fim do escolha
        }//fim do método

        public void Deletar()
        {
            Console.WriteLine("Informe um código");
            codigo = Convert.ToInt32(Console.ReadLine());
            //Utilizar o método excluir
            Console.WriteLine("\n\n" + conectar.Excluir(codigo));
        }//
    }//fim da classe   
}//fim do projeto
