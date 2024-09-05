using System;
namespace TP07.Models;
public class Dificultad
{
    public int idDificultad { get; set;}
    public string Nombre  { get; set; }  

    public Dificultad () {}
    public Dificultad (int IDDificultad, string nombre)
        {
        idDificultad = IDDificultad;
        Nombre = nombre;   
        }
    
}
