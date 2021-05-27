using System;

namespace GrenaisURI1131
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis declaradas.
            int vitoriasInter = 0, vitoriasGremio = 0, empates = 0;            
            int repeteOperacao = 1;


            /* Estrutura de repeticao para receber os dados ate que o usuario encerre o programa 
            com a opcao "2". */
            while (repeteOperacao == 1)
            {
                //Efetua a leitura dos dados, ".Split para recortar a string".
                string[] vet = Console.ReadLine().Split(' ');
                
                //Apos recortar a string, insere cada parte no seu devido local.
                int golsInter = int.Parse(vet[0]);
                int golsGremio = int.Parse(vet[1]);                

                //Verifica e soma as vitorias de cada time, ou se terminou empatado.
                if (golsInter > golsGremio)
                {
                    vitoriasInter = vitoriasInter + 1;
                }

                else if (golsInter < golsGremio)
                {
                    vitoriasGremio = vitoriasGremio + 1;
                }

                else
                {                    
                    empates = empates + 1;
                }

                /*Repete a operacao e continua a somar, caso o usuario digite 1
                para repetir a operacao.*/
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repeteOperacao = int.Parse(Console.ReadLine());
                                
            }

            //Soma o total geral de jogos.
            int totalGrenais = vitoriasInter + vitoriasGremio + empates;

            //Imprime os valores completos
            Console.WriteLine(totalGrenais + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);
                        
            //Condicao para verificar qual time obteve mais vitorias.
            if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }

            else if(vitoriasInter < vitoriasGremio)
            {
                Console.WriteLine("Gremio venceu mais");
            }

            else
            {
                Console.WriteLine("Nao houve vencedor");
            }                             

        }
    }
}
