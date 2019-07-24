using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Api.Controllers
{
  [RoutePrefix("api/candidatos")]
  public class CandidatosController : ApiController
  {
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public IHttpActionResult GetAll()
    {
      List<CandidatosModel> listaCandidatos = new List<CandidatosModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadCandidato";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaCandidatos.Add
            (
                new CandidatosModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),                  
                  FkVaga = Convert.ToInt32(sdr.GetValue(1)),
                  Nome = sdr.GetValue(2).ToString()
                }
            );
      }
      sqlconn.Close();
      return Ok(listaCandidatos);
    }

    [AcceptVerbs("GET")]
    [Route("GetById/{codigo}")]
    public IHttpActionResult GetById(int codigo)
    {
      List<CandidatosModel> listaCandidatosId = new List<CandidatosModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadCandidato Where Pk = " + codigo;
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaCandidatosId.Add
            (
                new CandidatosModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  FkVaga = Convert.ToInt32(sdr.GetValue(1)),
                  Nome = sdr.GetValue(2).ToString()
                }
            );
      }
      sqlconn.Close();
      return Ok(listaCandidatosId);
    }

    [AcceptVerbs("POST")]
    [Route("Insert")]
    public string Insert([FromBody] CandidatosModel candidatos)
    {
      if (candidatos != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Insert CadCandidato(Nome, FkVaga) Values('" + candidatos.Nome + "'," + candidatos.FkVaga + ")";
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Candidato: " + candidatos.Nome + " cadastrado com sucesso";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("PUT")]
    [Route("Update")]
    public string Update(CandidatosModel candidatos)
    {
      if (candidatos != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Update CadCandidato Set Nome = '" + candidatos.Nome + "', FkVaga = " + candidatos.FkVaga + " Where Pk = " + candidatos.Pk;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        return "Candidato: " + candidatos.Nome + " foi alterado com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("DELETE")]
    [Route("Delete/{codigo}")]
    public string Delete(int codigo)
    {
      if (codigo != 0)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Delete CadCandidato Where Pk = " + codigo;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Candidato removido com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

  }
}
