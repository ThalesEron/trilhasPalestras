using System;
using System.Collections.Generic;

namespace testeeturn {

    class Program {

        static void Main(string[] args) {

            var trilha1 = new List<Palestra>();
            var trilha2 = new List<Palestra>();

            AgendarPalestra palestra = new AgendarPalestra();
            ListarEventos evento = new ListarEventos();

            //Fiz também o projeto com inserção manual dos eventos, caso queira dar uma olhada: https://github.com/ThalesEron/trilhasPalestrasManual

            try {
                palestra.AgendarPalestras("Escrevendo testes rápidos", 60, trilha1);
                palestra.AgendarPalestras("Uma visão sobre Python", 45, trilha1);
                palestra.AgendarPalestras("Angular", 30, trilha1);
                palestra.AgendarPalestras("Otimizando aplicações com NodeJS", 45, trilha1);
                palestra.AgendarPalestras("Ruby on Rails: Por que devemos migrar para ele?", 60, trilha1);
                palestra.AgendarPalestras("Erros comuns no desenvolvimento de software", 45, trilha1);
                palestra.AgendarPalestras("Pair Programming vs Noise", 45, trilha1);
                palestra.AgendarPalestras("Java e os novos paradigmas de programação", 30, trilha1);
                palestra.AgendarPalestras("Rubi vs. Clojure para Back-End", 30, trilha1);
                palestra.AgendarPalestras("UX", 30, trilha1);
                Console.WriteLine("Trilha 1");
                evento.ListarEvento(trilha1);

                palestra.AgendarPalestras("Asp.net MVC", 60, trilha2);
                palestra.AgendarPalestras("Mobilidade em desenvolvimento", 60, trilha2);
                palestra.AgendarPalestras("Woah", 30, trilha2);
                palestra.AgendarPalestras("Sente e escreva", 30, trilha2);
                palestra.AgendarPalestras("TDD na prática", 45, trilha2);
                palestra.AgendarPalestras("Otimizando aplicações .NET", 45, trilha2);
                palestra.AgendarPalestras("Um mundo sem stackoverflow", 30, trilha2);
                palestra.AgendarPalestras("Scrum para leigos", 60, trilha2);
                palestra.AgendarPalestras("Rails para Desenvolvedor Python", 60, trilha2);
                Console.WriteLine("Trilha 2");
                evento.ListarEvento(trilha2);
            } catch {
                Console.WriteLine("Algum erro aconteceu, programa encerrado.");
            }

        }

    }

}