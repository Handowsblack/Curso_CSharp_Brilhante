using MyApp.Saudacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseOlaMundo minhaClasse = new ClasseOlaMundo();
            ClasseOpaBao olaUsuarioInstancia = new ClasseOpaBao(); 
            minhaClasse.EscreverOlaMundo();
            olaUsuarioInstancia.EscreverOpaBao("Alequin");
            Console.ReadKey();
        }
    }
}
