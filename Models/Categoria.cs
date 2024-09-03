using System;
namespace TP07.Models;
public class Categoria
{

    public int idCategoria { get; set;}
    public string Nombre  { get; set; }  
    public string Foto {get; set;}

    public Categoria () {}
    public Categoria (int IDCategoria, string nombre, string foto)
        {
        idCategoria = IDCategoria;
        Nombre = nombre;   
        Foto=foto;
        }
    
}
