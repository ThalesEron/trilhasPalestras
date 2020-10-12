using System;
using System.Collections.Generic;

namespace testeeturn {

    class Program {

        static void AgendarPalestras(string nome, int time, List<Palestra> palestras) {

            palestras.Add(new Palestra {
                Nome = nome,
                    Time = time
            });

        }

        static void ListarEventos(List<Palestra> palestras) {
            DateTime data1 = new DateTime();
            data1 = data1.AddHours(9);
            data1 = data1.AddMinutes(0);

            foreach (var palestra in palestras) {
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

        static void Main(string[] args) {

            var trilha1 = new List<Palestra>();
            var trilha2 = new List<Palestra>();

            AgendarPalestras("Escrevendo testes rápidos", 60, trilha1);
            AgendarPalestras("Uma visão sobre Python", 45, trilha1);
            AgendarPalestras("Angular", 30, trilha1);
            AgendarPalestras("Otimizando aplicações com NodeJS", 45, trilha1);
            AgendarPalestras("Ruby on Rails: Por que devemos migrar para ele?", 60, trilha1);
            AgendarPalestras("Erros comuns no desenvolvimento de software", 45, trilha1);
            AgendarPalestras("Pair Programming vs Noise", 45, trilha1);
            AgendarPalestras("Java e os novos paradigmas de programação", 30, trilha1);
            AgendarPalestras("Rubi vs. Clojure para Back-End", 30, trilha1);
            AgendarPalestras("UX", 30, trilha1);
            Console.WriteLine("Trilha 1");
            ListarEventos(trilha1);

            AgendarPalestras("Asp.net MVC", 60, trilha2);
            AgendarPalestras("Mobilidade em desenvolvimento", 60, trilha2);
            AgendarPalestras("Woah", 30, trilha2);
            AgendarPalestras("Sente e escreva", 30, trilha2);
            AgendarPalestras("TDD na prática", 45, trilha2);
            AgendarPalestras("Otimizando aplicações .NET", 45, trilha2);
            AgendarPalestras("Um mundo sem stackoverflow", 30, trilha2);
            AgendarPalestras("Scrum para leigos", 60, trilha2);
            AgendarPalestras("Rails para Desenvolvedor Python", 60, trilha2);
            Console.WriteLine("Trilha 2");
            ListarEventos(trilha2);

        }

    }

}