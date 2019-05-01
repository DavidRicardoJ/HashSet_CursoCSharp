using System;
using System.Collections.Generic;

namespace HashSet_CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CursoA = new HashSet<int>();
            HashSet<int> CursoB = new HashSet<int>();
            HashSet<int> CursoC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < n; i++)
            {
                CursoA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nO curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < n; i++)
            {
                CursoB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nO curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < n; i++)
            {
                CursoC.Add(int.Parse(Console.ReadLine()));
            }
            CursoA.UnionWith(CursoB);
            CursoA.UnionWith(CursoC);
            Console.WriteLine("\nTotal de Alunos: " + CursoA.Count.ToString());

        }
    }

    /*No portal de cursos online Udemy, cada usuário possui um código único, representado por um número inteiro.
Cada instrutor do portal Udemy pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos
cursos quiser. Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os
cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.
O instrutor Joaquim possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Joaquim, depois mostrar a quantidade total e alunos
dele, conforme exemplo.
Veja o exemplo (os valores que devem ser digitados pelo usuário estão destacados em vermelho):
Exemplo:
O curso A possui quantos alunos? 3
Digite os códigos dos alunos do curso A:
21
35
22
O curso B possui quantos alunos? 2
Digite os códigos dos alunos do curso B:
21
50
O curso C possui quantos alunos? 3
Digite os códigos dos alunos do curso C:
42
35
13
Total de alunos: 6  */

}
