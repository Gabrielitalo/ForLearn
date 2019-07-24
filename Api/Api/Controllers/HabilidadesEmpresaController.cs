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
  [RoutePrefix("api/EmpresaH")]
  public class HabilidadesEmpresaController : ApiController
  {
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public IHttpActionResult GetAll()
    {
      List<HabilidadesEmpresaModel> listaEmpresa = new List<HabilidadesEmpresaModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadHabilidadeEmpresa";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaEmpresa.Add
              (
                  new HabilidadesEmpresaModel()
                  {
                    Pk = Convert.ToInt32(sdr.GetValue(0)),
                    Habilidade = sdr.GetValue(1).ToString()
                  }
              );
        }
      sqlconn.Close();
      return Ok(listaEmpresa);
    }

    [AcceptVerbs("GET")]
    [Route("GetById/{codigo}")]
    public IHttpActionResult GetById(int codigo)
    {
      List<HabilidadesEmpresaModel> listaEmpresaId = new List<HabilidadesEmpresaModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From CadHabilidadeEmpresa Where Pk = " + codigo;
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaEmpresaId.Add
            (
                new HabilidadesEmpresaModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  Habilidade = sdr.GetValue(1).ToString()
                }
            );
         sqlconn.Close();
      }
      return Ok(listaEmpresaId);
    }


    [AcceptVerbs("POST")]
    [Route("Insert")]
    public string Insert([FromBody] HabilidadesEmpresaModel empresa)
    {
      if (empresa != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Insert CadHabilidadeEmpresa(Habilidade) Values('" + empresa.Habilidade + "')";
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Habilidade: " + empresa.Habilidade + " adicionada com sucesso as tecnologias que a empresa trabalha.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("PUT")]
    [Route("Update")]
    public string Update(HabilidadesEmpresaModel empresa)
    {
      if (empresa != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Update CadHabilidadeEmpresa Set Habilidade = '" + empresa.Habilidade + "' Where Pk = " + empresa.Pk;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Habilidade: " + empresa.Habilidade + " alterada com sucesso.";
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
        string SqlQuery = "Delete CadHabilidadeEmpresa Where Pk = " + codigo;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Habilidade removida com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }
  }
}
