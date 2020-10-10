using System;

namespace testeeturn
{

    struct Palestra
    {
        public string nome;

        public int time;


    }

    class Program
    {
        static void Main(string[] args)
        {
           

            DateTime data1 = new DateTime();
            data1 = data1.AddHours(9);
            data1 = data1.AddMinutes(0);

            Palestra[] palestras = new Palestra[19];

            palestras[0].nome = "Escrevendo testes rápidos";
            palestras[0].time = 60;

            palestras[1].nome = "Uma visão sobre Python";
            palestras[1].time = 45;

            palestras[2].nome = "Angular";
            palestras[2].time = 30;

            palestras[3].nome = "Otimizando aplicações com NodeJS";
            palestras[3].time = 45;

            palestras[4].nome = "Ruby on Rails: Por que devemos migrar para ele?";
            palestras[4].time = 60;

            palestras[5].nome = "Erros comuns no desenvolvimento de software";
            palestras[5].time = 45;

            palestras[6].nome = "Pair Programming vs Noise";
            palestras[6].time = 45;

            palestras[7].nome = "Java e os novos paradigmas de programação";
            palestras[7].time = 30;

            palestras[8].nome = "Ruvi vs. Clojure para Back-End";
            palestras[8].time = 30;

            palestras[9].nome = "UX";
            palestras[9].time = 30;

            palestras[10].nome = "Asp.net MVC";
            palestras[10].time = 60;

            palestras[11].nome = "Mobilidade em desenvolvimento";
            palestras[11].time = 60;

            palestras[12].nome = "Woah";
            palestras[12].time = 30;

            palestras[13].nome = "Sente e escreva";
            palestras[13].time = 30;

            palestras[14].nome = "TDD na prática";
            palestras[14].time = 45;

            palestras[15].nome = "Otimizando aplicações .NET";
            palestras[15].time = 45;

            palestras[16].nome = "Um mundo sem stackoverflow";
            palestras[16].time = 30;

            palestras[17].nome = "Scrum para leigos";
            palestras[17].time = 60;

            palestras[18].nome = "Rails para Desenvolvedor Python";
            palestras[18].time = 60;

            Console.WriteLine("Trilha 1");
            for (int i = 0; i < 10; i++)
            {

                string[] horario = data1.GetDateTimeFormats('t');
                int hourDate = data1.Hour;

                if (hourDate == 12)
                {
                    Console.WriteLine("{0} Almoço", horario[0]);
                    data1 = data1.AddMinutes(60);
                    i--;
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}min", horario[0], palestras[i].nome, palestras[i].time);
                    data1 = data1.AddMinutes(palestras[i].time);
                }



            }
            Console.WriteLine("17:00 Evento de Networking");


            data1 = data1.AddHours(-8);
            Console.WriteLine("Trilha 2");
            for (int i = 10; i < 19; i++)
            {

                string[] horario = data1.GetDateTimeFormats('t');
                int hourDate = data1.Hour;

                if (hourDate == 12)
                {
                    Console.WriteLine("{0} Almoço", horario[0]);
                    data1 = data1.AddMinutes(60);
                    i--;
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}min", horario[0], palestras[i].nome, palestras[i].time);
                    data1 = data1.AddMinutes(palestras[i].time);
                }



            }

            Console.WriteLine("17:00 Evento de Networking");



        }


    }




}
