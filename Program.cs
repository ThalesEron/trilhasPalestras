using System;
using System.Collections.Generic;

namespace testeeturn {

    class Program {

        static List<Palestra> trilha1 = new List<Palestra>();
        static List<Palestra> trilha2 = new List<Palestra>();
        static void AgendarPalestras(string nome, int time) {

            trilha1.Add(new Palestra {
                Nome = nome,
                    Time = time
            });

            trilha2.Add(new Palestra {
                Nome = nome,
                    Time = time
            });
        }

        static void Main(string[] args) {

            DateTime data1 = new DateTime();
            data1 = data1.AddHours(9);
            data1 = data1.AddMinutes(0);

            AgendarPalestras("Escrevendo testes rápidos", 60);
            AgendarPalestras("Uma visão sobre Python", 45);
            AgendarPalestras("Angular", 30);
            AgendarPalestras("Otimizando aplicações com NodeJS", 45);
            AgendarPalestras("Ruby on Rails: Por que devemos migrar para ele?", 60);
            AgendarPalestras("Erros comuns no desenvolvimento de software", 45);
            AgendarPalestras("Pair Programming vs Noise", 45);
            AgendarPalestras("Java e os novos paradigmas de programação", 30);
            AgendarPalestras("Rubi vs. Clojure para Back-End", 30);
            AgendarPalestras("UX", 30);

            Console.WriteLine("Trilha 1");

            foreach (var palestra in trilha1) {
                string horario = data1.GetDateTimeFormats('t')[0];
                if (data1.Hour == 12) {
                    Console.WriteLine("{0} Almoço", horario);
                    data1 = data1.AddMinutes(60);
                    horario = data1.GetDateTimeFormats('t')[0];
                }

                Console.WriteLine("{0} {1} {2}min", horario, palestra.Nome, palestra.Time);
                data1 = data1.AddMinutes(palestra.Time);

            }

            Console.WriteLine("17:00 Evento de Networking");

            AgendarPalestras("Asp.net MVC", 60);
            AgendarPalestras("Mobilidade em desenvolvimento", 60);
            AgendarPalestras("Woah", 30);
            AgendarPalestras("Sente e escreva", 30);
            AgendarPalestras("TDD na prática", 45);
            AgendarPalestras("Otimizando aplicações .NET", 45);
            AgendarPalestras("Um mundo sem stackoverflow", 30);
            AgendarPalestras("Scrum para leigos", 60);
            AgendarPalestras("Rails para Desenvolvedor Python", 60);

            data1 = data1.AddHours(-8);
            Console.WriteLine("Trilha 2");
             foreach (var palestra in trilha2) {
                string horario = data1.GetDateTimeFormats('t')[0];
                if (data1.Hour == 12) {
                    Console.WriteLine("{0} Almoço", horario);
                    data1 = data1.AddMinutes(60);
                    horario = data1.GetDateTimeFormats('t')[0];
                }

                Console.WriteLine("{0} {1} {2}min", horario, palestra.Nome, palestra.Time);
                data1 = data1.AddMinutes(palestra.Time);

            }

            Console.WriteLine("17:00 Evento de Networking");

        }

    }

}