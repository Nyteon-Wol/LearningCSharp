﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[6];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Cleiton";
            alunos[4] = "Julia";
            alunos[5] = "Juliana";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8, 7.3 };

            //foreach (var nota in notas)
            //{
            //    somatorio += nota;
            //}

            for(int i = 0; i < notas.Length; i++)
            {
                somatorio += notas[i];
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'T', 'a', 'y', 'l', 'o', 'r' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
