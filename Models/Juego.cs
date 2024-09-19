using System;
namespace TP07.Models;
public static class Juego
{

    private static string Username;
    private static int PuntajeActual; 
    private static int CantidadPreguntasCorrectas;
    private static int ContadorNroPreguntaActual;
    private static Pregunta PreguntaActual;
    private static List<Pregunta> ListaPreguntas;
    private static List<Respuesta> ListaRespuestas;

    private static void InicializarJuego() {
        Username = "";
        PuntajeActual = 0;
        CantidadPreguntasCorrectas = 0;
        ContadorNroPreguntaActual = 0; 
        PreguntaActual = null;
        ListaPreguntas = null;
        ListaRespuestas = null;
    }

    public static List<Categoria> ObtenerCategor() {
        
        List<Categoria> categorias = new List<Categoria>();
        categorias = BD.ObtenerCategorias();
        return categorias;
    }

    public static List<Dificultad> ObtenerDificult() {
        
        List<Dificultad> dificultades = new List<Dificultad>();
        dificultades = BD.ObtenerDificultades();
        return dificultades;
    }
    public static void CargarPartida(string username, int dificultad, int categoria) {
        
        InicializarJuego();
        Username = username;
        ListaPreguntas = BD.ObtenerPreguntas(dificultad, categoria);      
    }

    public static Pregunta ObtenerProximaPregunta ()
    {
        if(ContadorNroPreguntaActual >= ListaPreguntas.Count())
        {
            return null;
        }
        return ListaPreguntas[ContadorNroPreguntaActual];
    }

    public static List<Respuesta> ObtenerProximasRespuestas (int idPregunta){

        
        return ListaRespuestas = BD.ObtenerRespuestas(idPregunta);
         
    } 

    public static bool VerificarRespuesta(int idRespuesta){
        
        bool Correcta = false;
        foreach(Respuesta item in ListaRespuestas)
        {
            if (item.idRespuesta == idRespuesta) // esto busca al id de la respuesta para chequear que dicha resuesta, en su respectivo campo "Correcto", sea true o false
            {
                Correcta = item.Correcta;
            }
        }

        if (Correcta == true) {
            PuntajeActual += 5;
            CantidadPreguntasCorrectas ++;
        }

        ContadorNroPreguntaActual ++;
        PreguntaActual = ObtenerProximaPregunta();

        return Correcta;
    }

    public static int ObtenerPuntaje()
    {
        return PuntajeActual;
    }

    public static string ObtenerNombre()
    {
        return Username;
    }

    public static int ObtenerProgreso()
    {
        return ContadorNroPreguntaActual;
    }

}