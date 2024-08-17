using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace pasteMain
{
    public class ClasseDeAula
    {
        List<string> ListaDeAlunos = new List<string>();

        public void ColocaNomeDoaluno(){
            Console.WriteLine("coloque nome de um aluno");
            string alunoAdd = Console.ReadLine();
            ListaDeAlunos.Add(alunoAdd);
        }
        public void VerListaDeAlunos (){
            if(ListaDeAlunos.Any()){
                Console.WriteLine($"Aqui estão a lista de alunos \n\t");
                for(int contador = 1; contador < ListaDeAlunos.Count;contador++){
                    Console.WriteLine($"{contador}°{ListaDeAlunos[contador]}");
                }
            }
            else{
                Console.WriteLine("esse aluno não estar nessa turma");
            }

        }
        public void ColocaNota(){
            Console.WriteLine("qual nome do aluno?");
            string ColocandoNota = Console.ReadLine();
            if(ListaDeAlunos.Any(x => x == ColocandoNota)){
                Console.WriteLine($"qual nota o {ColocandoNota} tem pra nos fazer a media\nqual a primeira nota ?");   
                int nota1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("qual segunda nota?");
                int nota2 = Convert.ToInt32(Console.ReadLine()); 
                  Stopwatch relogio = new Stopwatch();
                relogio.Start();
                Console.WriteLine("Calculando...");
                System.Threading.Thread.Sleep(5000); // 5 sec
            
                relogio.Stop();
                int media = (nota1 + nota2)/2;
                    if(media > 30){
                        string aprovado = "aprovado";
                        Console.Clear();
                        Console.WriteLine($"aluno {ColocandoNota} sua media é :{media} portanto ele esta {aprovado}");
                        
                    }
                    else{
                        string reprovado = "reprovado";
                        Console.Clear();
                        Console.WriteLine($"aluno {ColocandoNota} sua media é :{media} portanto ele esta {reprovado}");
                    }
                

            }
            else{
                Console.WriteLine("Nenhum aluno encontrado nesse lista");
            }
            
        



        }
    }
}