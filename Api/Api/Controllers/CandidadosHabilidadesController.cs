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
  [RoutePrefix("api/candidatoshabilidade")]
  public class CandidadosHabilidadesController : ApiController
  {
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public IHttpActionResult GetAll()
    {
      List<CandidatosHabilidadesModel> listaCandidatosH = new List<CandidatosHabilidadesModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CandHabilidades";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaCandidatosH.Add
            (
                new CandidatosHabilidadesModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  FkCand = Convert.ToInt32(sdr.GetValue(1)),
                  FkCadEmpresaH = Convert.ToInt32(sdr.GetValue(2))
                }
            );
      }
      sqlconn.Close();
      return Ok(listaCandidatosH);
    }

    [AcceptVerbs("GET")]
    [Route("GetById/{codigo}")]
    public IHttpActionResult GetById(int codigo)
    {
      List<CandidatosHabilidadesModel> listaCandidatosId = new List<CandidatosHabilidadesModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CandHabilidades Where Pk = " + codigo;
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaCandidatosId.Add
            (
                new CandidatosHabilidadesModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  FkCand = Convert.ToInt32(sdr.GetValue(1)),
                  FkCadEmpresaH = Convert.ToInt32(sdr.GetValue(2))
                }
            );
      }
      sqlconn.Close();
      return Ok(listaCandidatosId);
    }

    [AcceptVerbs("POST")]
    [Route("Insert")]
    public string Insert([FromBody] CandidatosHabilidadesModel candidatos)
    {
      if (candidatos != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Insert CandHabilidades(FkCadEmpresaH, FkCand) Values(" + candidatos.FkCadEmpresaH + "," + candidatos.FkCand + ")";
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Habilidade cujo o código interno: " + candidatos.FkCadEmpresaH + " adicionada com sucesso para o candidato de código: " + candidatos.FkCand;
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("PUT")]
    [Route("Update")]
    public string Update(CandidatosHabilidadesModel candidatos)
    {
      if (candidatos != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Update CandHabilidades Set FkCand = " + candidatos.FkCand + ", FkCadEmpresaH = " + candidatos.FkCadEmpresaH + " Where Pk = " + candidatos.Pk;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        return "Habilidade cujo o código interno: " + candidatos.FkCadEmpresaH + " alterada com sucesso para o candidato de código: " + candidatos.FkCand;
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
        string SqlQuery = "Delete CandHabilidades Where Pk = " + codigo;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Habilidade do candidato removida com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }
  }
}
