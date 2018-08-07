using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um aluno
            Aluno aluno = new Aluno();
            aluno.Nome = "Jefty"; //set
            Console.WriteLine(aluno.Nome); //get

            //instanciar um professor

            Professor prof = new Professor() {
                Nome = "Cabral",
                Pf = "PF122",

            };

            //Professor prof2 = new Professor("Parducci");
            var prof2 = new Professor("Parducci");

            var x = 10;

        }
    }
}
