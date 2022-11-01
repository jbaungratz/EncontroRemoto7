// See https://aka.ms/new-console-template for more information
using UC12_SA2_ER5;

Console.WriteLine(@$"
********************************************************************************
********************************************************************************
*                                                                              *
*               Seja bem vindo ao Sistema de Controle Financeiro               *
*                                                                              *
********************************************************************************
********************************************************************************
");

List<Corrente> listaCC = new List<Corrente>();
List<Poupanca> listaCPP = new List<Poupanca>();

BarraCarregamento("Carregando", 200);
Console.Clear();
string? escolha;

do
{

    Console.WriteLine(@$"
********************************************************************************
********************************************************************************
*                                                                              *
*                       Escolha uma das opções a seguir:                       *
*                                                                              *
*                               1 - Conta Corrente                             *
*                               2 - Conta Poupança                             *
*                               0 - Sair                                       *
*                                                                              *
*                                                                              *
********************************************************************************
********************************************************************************
");
    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            string? escolhaCC;
            do
            {
               
                Console.Clear();    
                    Console.WriteLine(@$"
********************************************************************************
********************************************************************************
*                                                                              *
*                       Escolha uma das opções a seguir:                       *
*                                                                              *
*                               1 - Cadastrar Conta Corrente                   *
*                               2 - Mostrar Conta Corrente                     *
*                               0 - Voltar ao Menu Anterior                    *
*                                                                              *
*                                                                              *
********************************************************************************
********************************************************************************                    
");
            escolhaCC = Console.ReadLine();

            switch (escolhaCC)
            {
                case "1":
                    Console.WriteLine($"Digite o número da conta corrente: ");
                    string numero = Console.ReadLine();
                    
                    Console.WriteLine($"Digite o número da agência: ");
                    string agencia = Console.ReadLine();

                    Console.WriteLine($"Digite o limite: ");
                    double limite = Double.Parse(Console.ReadLine());

                    Corrente obj_cc = new Corrente(numero, agencia, limite);
                    
                    listaCC.Add(obj_cc);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Cadastro Realizado com Sucesso!");
                    Console.ResetColor();

                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                case "2":
                    Console.Clear();
                    if (listaCC.Count > 0)
                    {
                        foreach(Corrente cadaCC in listaCC) {
                            Console.Clear();
                            Console.WriteLine($"{cadaCC.ToString()}");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();
                            //Console.Clear();
                        }
                    }
                    else {
                        Console.WriteLine($"A Lista está vazia!");
                        Thread.Sleep(3000);
                    }

                    break;                                        
                default:

                    Console.Clear();
                    Console.WriteLine($"Opção inválida, por favor digite outra opção");
                    Thread.Sleep(2000);
                    Console.Clear();     
                    break;
            }
            
            } while (escolhaCC != "0");
            break;

        case "2": // conta Poupanca

            string? escolhaCPP;
            do
            {
               
                Console.Clear();    
                    Console.WriteLine(@$"
********************************************************************************
********************************************************************************
*                                                                              *
*                       Escolha uma das opções a seguir:                       *
*                                                                              *
*                               1 - Cadastrar Conta Poupança                   *
*                               2 - Mostrar Conta Poupança                     *
*                               0 - Voltar ao Menu Anterior                    *
*                                                                              *
*                                                                              *
********************************************************************************
********************************************************************************                    
");
            escolhaCPP = Console.ReadLine();

            switch (escolhaCPP)
            {
                case "1":
                    Console.WriteLine($"Digite o número da conta poupança: ");
                    string numero = Console.ReadLine();
                    
                    Console.WriteLine($"Digite o número da agência: ");
                    string agencia = Console.ReadLine();

                    Console.WriteLine($"Digite o aniverário: ");
                    int aniversario = Int32.Parse(Console.ReadLine());

                    Poupanca obj_cpp = new Poupanca(numero, agencia, aniversario);
                    
                    listaCPP.Add(obj_cpp);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Cadastro Realizado com Sucesso!");
                    Console.ResetColor();

                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                case "2":
                    Console.Clear();
                    if (listaCPP.Count > 0)
                    {
                        foreach(Poupanca cadaCPP in listaCPP) {
                            Console.Clear();
                            Console.WriteLine($"{cadaCPP.ToString()}");
                            Console.WriteLine($"Aperte 'Enter' para continuar");
                            Console.ReadLine();
                            //Console.Clear();
                        }
                    }
                    else {
                        Console.WriteLine($"A Lista está vazia!");
                        Thread.Sleep(3000);
                    }

                    break;                                        
                default:

                    Console.Clear();
                    Console.WriteLine($"Opção inválida, por favor digite outra opção");
                    Thread.Sleep(2000);
                    Console.Clear();     
                    break;
            }
            
            } while (escolhaCPP != "0");
            break;

                 
                    Console.Clear();
                    Console.WriteLine($"Obrigado por utilizar nosso sistema!");
                    BarraCarregamento("Finalizando", 200);
                    break;
                    

                default:

                    Console.Clear();
                    Console.WriteLine($"Opção inválida, por favor digite outra opção");
                    Thread.Sleep(3000);
                    Console.Clear();     
                    break;
        }

} while (escolha != "0");

static void BarraCarregamento(string texto, int tempo) {

    Console.BackgroundColor = ConsoleColor.DarkCyan;

    Console.Write($"{texto}");

        for (var contador = 0; contador < 10; contador++)
        {
            Console.Write(". ");
            Thread.Sleep(tempo);
        }

    Console.ResetColor();
    Console.Clear();
}



