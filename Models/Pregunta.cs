using System;
namespace TP07.Models;
public class Pregunta
{

    public int idPregunta { get; set;}
    public int idCategoria  { get; set; }  
    public int idDificultad  { get; set; }  
    public string Enunciado  { get; set; }  
    public string Foto  { get; set; }  

    public Pregunta () {}
    public Pregunta (int IDPregunta, int IDCategoria, int IDDificultad, string enunciado, string foto )
        {
            idPregunta=IDPregunta;
            idCategoria=IDCategoria;
            idDificultad=IDDificultad;
            Enunciado=enunciado;
            Foto=foto;
        }
    
}