//Screen Sound

string saudacao = "Boas vindas";
//List<string> bandas = new List<string>{"U2","AudioSlave"};
//List<string> bandas = new List<string>();
Dictionary<string,List<int>> bandas = new Dictionary<string, List<int>>();

void ExibirLogo(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(saudacao);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine())!;

    switch (opcao) 
{
    case 1:
        registrarBanda();
        
        break;
    case 2:
        ExibirBandas();
        break;
    case 3:
        AvaliarBanda();
        break;
    case 4:
        ExibirMedia();
        break;
    case -1:
        Console.WriteLine("Você escolheu a opção " + opcao);
        break;
}
}

void registrarBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja Registrar: ");
    string banda = Console.ReadLine()!;
    bandas.Add(banda,new List<int>());
    Console.WriteLine($"A banda {banda} foi registrada com sucesso!");
    
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas(){
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas!");
    
    // for (int i = 0; i < bandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {bandas[i]}");
    // }
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("Digite qualquer tecla para sair!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo){
    int qtdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda(){
    Console.Clear();
    ExibirTituloDaOpcao("Avalia banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string banda = Console.ReadLine()!;
    if (bandas.ContainsKey(banda))
    {
        Console.Write($"Qual a nota que a banda {banda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[banda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {banda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else{
        Console.WriteLine($"\nA banda {banda} não foi encontrado!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia(){
    Console.Clear();
    ExibirTituloDaOpcao("Média de uma banda");
    
    string banda = Console.ReadLine()!;
    Console.Write($"Qual a nota que a banda {banda}: ");
    if (bandas.ContainsKey(banda))
    {
        
        double media = bandas[banda].Average();
        Console.WriteLine($"A banda {banda} possui a média de {media}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else{
        Console.WriteLine($"\nA banda {banda} não foi encontrado!");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();


