using System;
using System.Data.SqlClient;
using Dapper;

namespace TP07.Models;

public static class BD{
    private static string _connectionString = @"Server=localhost; DataBase=Tp07;Trusted_Connection=True;";
    
    public static List<Categoria> ObtenerCategorias() {
        List<Categoria> categorias = new List<Categoria>();
        string SQL = "Select * From Categorias";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            categorias=db.Query<Categoria>(SQL).ToList();
        }
        return categorias;
    }

    public static List<Dificultad> ObtenerDificultades() {
        List<Dificultad> dificultades = new List<Dificultad>();
        string SQL = "Select * From Dificultades";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            dificultades=db.Query<Dificultad>(SQL).ToList();
        }
        return dificultades;
    }

    public static List<Pregunta> ObtenerPreguntas(int dificultad, int categoria) {

        List<Pregunta> preguntas  = new List<Pregunta>();

        if (dificultad > -1 && categoria > -1) {
           
            string SQL = "SELECT * from Preguntas where IdDificultad = @pDificultad and IdCategoria = @pCategoria ";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                preguntas = db.Query<Pregunta>(SQL, new {pDificultad = dificultad, pCategoria = categoria}).ToList();
            }
        }
        else if (dificultad == -1 && categoria == -1) {
            
            string SQL = "SELECT * from Preguntas,Categorias";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                preguntas = db.Query<Pregunta>(SQL, new {pDificultad = dificultad, pCategoria = categoria}).ToList();
            }
        }

        else if (dificultad > -1 && categoria == -1){
            
            string SQL = "SELECT * from Categorias, Preguntas where IdDificultad = @pDificultad";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                preguntas = db.Query<Pregunta>(SQL, new {pDificultad = dificultad, pCategoria = categoria}).ToList();
            }
        }
        else if (dificultad == -1 && categoria > -1){
            
            string SQL = "SELECT * from Preguntas, Categorias where IdCategoria = @pCategoria";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                preguntas = db.Query<Pregunta>(SQL, new {pDificultad = dificultad, pCategoria = categoria}).ToList();
            }
        }
        
        return preguntas;
    }

    public static List<Respuesta> ObtenerRespuestas(int idPregunta) {
        List<Respuesta> respuestas = new List<Respuesta>();
        string SQL= "Select * From Preguntas where idPregunta = @pidPregunta";
            using(SqlConnection db = new SqlConnection(_connectionString))
            {
                respuestas = db.Query<Respuesta>(SQL, new {pidPregunta = idPregunta}).ToList();
            }
        return respuestas;
    }

}