using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public class Usuario
    {
        //atributos
        //modificador de acesso
        //tipo de dado
        //nome do atributo (varíavel)
        public string nome;
        public string email;
        public string login;
        public string senha;

        //Método especifico da classe
        public void provarExistencia()
        {
            Console.WriteLine("Oi, eu existo!");
        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Fala Palhaço");

            //Método construtor
            // tipo de dado | comando new | = | comando new | método construtor()

            Usuario u1 = new Usuario();

            //Nome da instancia.atributo = dados;
            u1.nome = "Pedro";
            u1.email = "pedro@gmail.com";
            u1.login = "pedro";
            u1.senha = "1234";

            //ivocando o método especifico da classe
            //chamando o nome da instancia.metodo()
            u1.provarExistencia();

            //exibindo os dados do objeto
            Console.WriteLine("\n" + u1.nome + "\n" + u1.email + "\n" + u1.login + "\n" + u1.senha + "\n");


            //usuario 2
            Usuario u2 = new Usuario();

            //Nome da instancia.atributo = dados;
            u2.nome = Console.ReadLine();
            u2.email = Console.ReadLine();
            u2.login = Console.ReadLine();
            u2.senha = Console.ReadLine();


            /* u2.nome = "Maria";
            u2.email = "mariaeduarda@gmail.com";
            u2.login = "duda";
            u2.senha = "5678";*/

            //ivocando o método especifico da classe
            //chamando o nome da instancia.metodo()
            u2.provarExistencia();

            //exibindo os dados do objeto
            Console.WriteLine("\n" + u2.nome +"\n"+ u2.email + "\n" + u2.login + "\n" + u2.senha);

        }
    }
}
