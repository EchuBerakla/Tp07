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

    public static List<Respuesta> ObtenerRespuestas(int dificultad, int categoria) {
        List<Respuesta> respuestas = new List<Respuesta>();
        //SEGUIR A PARTIR DE ACA

    }

}