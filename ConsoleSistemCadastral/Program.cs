using System;

namespace ConsoleSistemCadastral
{
    class Program
    {
         static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            ConsoleKey opcaoSelecionada;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Quinta");
                Console.WriteLine("=================================");
                Console.WriteLine("");
                Console.WriteLine("F1 - Cadasstrar documentos");
                Console.WriteLine("F2 - Pesquisar documentos");
                Console.WriteLine("F3 - Listar documentos");
                Console.WriteLine("");
                Console.WriteLine("F7 - Carregar documentos");
                Console.WriteLine("F8 - Salvar documentos");
                Console.WriteLine("");
                Console.WriteLine("F9 - Sair");

                opcaoSelecionada = Console.ReadKey(true).Key;

                switch (opcaoSelecionada)
                {
                    case ConsoleKey.F1:
                        CadastroDoc();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.F2:
                        Console.WriteLine("F2");
                        break;
                    case ConsoleKey.F3:
                        Console.WriteLine("F3");
                        break;
                    case ConsoleKey.F7:
                        // Executar a opção 7
                        break;
                    case ConsoleKey.F8:
                        // Executar a opção 8
                        break;
                    case ConsoleKey.F9:
                        // Executar a opção 9
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar.");
                        Console.ReadKey(true);
                        break;
                }
            } while (opcaoSelecionada != ConsoleKey.F9);
        }

        public static void CadastroDoc()
        {
            Console.WriteLine("Sistema de Quinta");
            Console.WriteLine("=================================");
            Console.WriteLine("");
            Console.WriteLine("Registro....  de  <N>");
            Console.WriteLine("");
            Console.Write("Nome........:");

            // Lê a entrada do usuário para o campo "Nome"
            string nome = Console.ReadLine();

            // Move o cursor para a próxima linha antes de imprimir o próximo campo
            Console.CursorTop++;

            Console.Write("RG..........:");
            string rg = Console.ReadLine();
            Console.CursorTop++;

            Console.Write("CPF.........:");
            string cpf = Console.ReadLine();
            Console.CursorTop++;

            Console.Write("Habilitação.:");
            string habilitacao = Console.ReadLine();
            Console.CursorTop++;

            Console.Write("Tit.Eleitor.:");
            string tituloEleitor = Console.ReadLine();
            Console.CursorTop++;

            Console.WriteLine("");
            Console.WriteLine("<F1> Insere novo <F2> Anterior <F3> Próximo <F5> Editar <F9> Sair");
        }


    }
}
