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
  [RoutePrefix("api/vagas")]
  public class VagasController : ApiController
  {
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public IHttpActionResult GetAll()
    {
      List<VagasModel> listaVagas = new List<VagasModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadVagas";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaVagas.Add
            (
                new VagasModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  Nome = sdr.GetValue(1).ToString()
                }
            );
      }
      sqlconn.Close();
      return Ok(listaVagas);
    }

    [AcceptVerbs("GET")]
    [Route("GetById/{codigo}")]
    public IHttpActionResult GetById(int codigo)
    {
      List<VagasModel> listaVagasId = new List<VagasModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadVagas Where Pk = " + codigo;
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaVagasId.Add
            (
                new VagasModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  Nome = sdr.GetValue(1).ToString()
                }
            );
      }
      sqlconn.Close();
      return Ok(listaVagasId);
    }

    [AcceptVerbs("POST")]
    [Route("Insert")]
    public string Insert([FromBody] VagasModel vagas)
    {
      if (vagas != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Insert CadVagas(Nome) Values('" + vagas.Nome + "')";
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();
        sqlconn.Close();
        return "Vaga: " + vagas.Nome + " adicionada com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("PUT")]
    [Route("Update")]
    public string Update(VagasModel vagas)
    {
      if (vagas != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Update CadVagas Set Nome = '" + vagas.Nome + "' Where Pk = " + vagas.Pk;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();
        sqlconn.Close();
        return "Vaga: " + vagas.Nome + " alterada com sucesso para o candidato de código: " + vagas.Pk;
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
        string SqlQuery = "Delete CadVagas Where Pk = " + codigo;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Vaga removida com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }
  }
}
