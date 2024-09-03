using System;
namespace TP07.Models;
public class Respuesta
{

    public int idRespuesta { get; set;}
    public int idPregunta  { get; set; }  
    public int Opcion  { get; set; }  
    public string Contenido  { get; set; }  
    public bool Correcta  { get; set; } 
    public string Foto  { get; set; }  

    public Respuesta () {}
    public Respuesta (int IDRespuesta, int IDPregunta, int opcion, string contenido, bool correcta, string foto )
        {
            idRespuesta=IDRespuesta;
            idPregunta=IDPregunta;
            Opcion=opcion;
            Contenido=contenido;
            Foto=foto;
        }
    
}