using System;

namespace Aula9_Senai.Poo.Aluno.Models
{
    public class AlunoModel
    {
    public string Nome{get; set;}

    public string Curso{get; set;}

    public string RA{get; set;}

    public void Estudar(){
        Console.WriteLine("Estou estudando");
    }

    public void pedirIntervalo() {
        System.Console.WriteLine("pode fazer intervalo aeee");
        System.Console.WriteLine("QUERO CAFÉÉÉ!!");
    }
    public void PedirAjuda(){
        System.Console.WriteLine("Ô Paulo, chega ae!");
    }
    }

}