using CelularPOO;

Console.Write("Está ligado? (S/N): ");
bool ligado = Console.ReadLine().ToLower() == "s" ? true : false;

Cell celular = new Cell();
// Console.WriteLine(@$"Características do celular:
//                      Cor: {celular.cor}
//                      Modelo: {celular.modelo}
//                      Tamanho: {celular.tamanho}");

Console.WriteLine(@"Escolha uma opção:
            __________________________________
            |1 - Ligar o aparelho            | 
            |2 - Desligar o aparelho         |  
            |3 - Fazer uma ligação telefônica|  
            |4 - Enviar Mensagem             |  
            ----------------------------------
            ");
int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        celular.Ligar();
        Console.WriteLine($"Ligando o celular");
        break;
    case 2:
        celular.Desligar();
        Console.WriteLine($"Celular desligado");
        break;
    case 3:
        Console.Write("Digite o número para fazer a ligação: ");
        string numeroLigacao = Console.ReadLine();
        celular.LigacaoTelefonica(numeroLigacao);
        break;
    case 4:
        Console.Write("Digite o número para enviar a mensagem: ");
        string numeroMensagem = Console.ReadLine();
        Console.Write("Digite a mensagem a ser enviada: ");
        string mensagem = Console.ReadLine();
        celular.EnviarMensagem(numeroMensagem, mensagem);

        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}