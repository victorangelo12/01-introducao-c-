using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{   
    /* classe abstrada não pode ser instanciada e
     * pode conter metodos abstrados
     * 
     */
     abstract class Pessoa
    {
        //contrutor
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        //Campos (atributos)
        private string _nome;

        //Propriedades (gets e sets)
        public float Peso { get; set; }

        public Genero Genero { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        //metodos
        //virtual -> permite a sobreescrita de metodo
        public virtual void Estudar()
        {
            Console.WriteLine("Estuda animale");
        }

        public abstract void FazerProva();
    }
}
