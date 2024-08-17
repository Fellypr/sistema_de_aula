using pasteMain;

ClasseDeAula classe = new ClasseDeAula();

Console.WriteLine("Qual seu nome?");
string nomeDoUsuario = Console.ReadLine();
bool encerra = true;
while(encerra){
    Console.Clear();
    Console.WriteLine($"olá {nomeDoUsuario} seja bem vindo \n Escolha uma das opções\n\t 1-coloca um nome na lista\n\t 2-coloca as notas\n\t 3- ver lista de aluno \n\t 4-encerra programa");
    int opção = Convert.ToInt32(Console.ReadLine());

    switch(opção){
        case 1:
            classe.ColocaNomeDoaluno();
        break;

        case 2:
            classe.ColocaNota();
        break;
        case 3:
            classe.VerListaDeAlunos();
        break;
        case 4:
            encerra = false;
        break;

        default:
            Console.WriteLine("opção invalida");
        break;

    }

    Console.WriteLine("aperte enter para continuar");
    Console.ReadLine();
}
Console.WriteLine("/////////////////////////////////");
Console.WriteLine("////////PROGRAMA ENCERRADO///////");
Console.WriteLine("/////////////////////////////////");
