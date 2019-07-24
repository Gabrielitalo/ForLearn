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
  [RoutePrefix("api/peso")]
  public class PesoVagasController : ApiController
  {
    [AcceptVerbs("GET")]
    [Route("GetAll")]
    public IHttpActionResult GetAll()
    {
      List<PesoVagasModel> listaPeso = new List<PesoVagasModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From PesoVagas";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaPeso.Add
            (
                new PesoVagasModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  FkVaga = Convert.ToInt32(sdr.GetValue(1)),
                  FkCadEmp = Convert.ToInt32(sdr.GetValue(2)),
                  Peso = Convert.ToInt32(sdr.GetValue(3))
                }
            );
      }
      sqlconn.Close();
      return Ok(listaPeso);
    }

    [AcceptVerbs("GET")]
    [Route("GetById/{codigo}")]
    public IHttpActionResult GetById(int codigo)
    {
      List<PesoVagasModel> listaPesoId = new List<PesoVagasModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery = "Select * From PesoVagas Where Pk = " + codigo;
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaPesoId.Add
            (
                new PesoVagasModel()
                {
                  Pk = Convert.ToInt32(sdr.GetValue(0)),
                  FkVaga = Convert.ToInt32(sdr.GetValue(1)),
                  FkCadEmp = Convert.ToInt32(sdr.GetValue(2)),
                  Peso = Convert.ToInt32(sdr.GetValue(3))
                }
            );
      }
      sqlconn.Close();
      return Ok(listaPesoId);
    }

    [AcceptVerbs("POST")]
    [Route("Insert")]
    public string Insert([FromBody] PesoVagasModel peso)
    {
      if (peso != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Insert PesoVagas(FkVaga, FkCadEmp, Peso) Values(" + peso.FkVaga + "," + peso.FkCadEmp + "," + peso.Peso + ")";
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Peso adicionado com sucesso para a vaga cujo o código é: " + peso.FkVaga;
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }

    [AcceptVerbs("PUT")]
    [Route("Update")]
    public string Update(PesoVagasModel peso)
    {
      if (peso != null)
      {
        string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
        SqlConnection sqlconn = new SqlConnection(Conn);
        string SqlQuery = "Update PesoVagas Set FkVaga = " + peso.FkVaga + ", FkCadEmp = " + peso.FkCadEmp + ", Peso = " + peso.Peso + " Where Pk = " + peso.Pk;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        return "Habilidade cujo o código interno: " + peso.FkCadEmp + " alterada com sucesso para a vaga de código: " + peso.FkVaga;
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
        string SqlQuery = "Delete PesoVagas Where Pk = " + codigo;
        sqlconn.Open();
        SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
        SqlDataReader sdr = SqlCmd.ExecuteReader();

        sqlconn.Close();
        return "Cadastro do peso para a vaga removido com sucesso.";
      }
      else
      {
        return "Nenhum valor foi informado para a API";
      }
    }
  }
}
