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
  [RoutePrefix("api/resultado")]
  public class ResultadoController : ApiController
    {
    [AcceptVerbs("GET")]
    [Route("PorVaga/{codigo}")]
    public IHttpActionResult PorVaga(int codigo)
    {
      List<ResultadoModel> listaResultados = new List<ResultadoModel>();
      string Conn = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
      SqlConnection sqlconn = new SqlConnection(Conn);
      string SqlQuery =
                        "Select C.Nome, Cv.Nome Vaga, sum(Cp.Peso) PontosTotais " +
                        "From CadCandidato C " +
                        "Join CadVagas Cv on (Cv.Pk = C.FkVaga) " +
                        "Join CandHabilidades Cc on (Cc.FkCand = C.Pk) " +
                        "Join PesoVagas Cp on (Cp.FkCadEmp = Cc.FkCadEmpresaH) " +
                        "Where (C.FkVaga = " + codigo + ") " +
                        "Group by C.Nome, Cv.Nome " +
                        "Order by sum(Cp.Peso) desc";
      sqlconn.Open();
      SqlCommand SqlCmd = new SqlCommand(SqlQuery, sqlconn);
      SqlDataReader sdr = SqlCmd.ExecuteReader();

      while (sdr.Read())
      {
        listaResultados.Add
            (
                new ResultadoModel()
                {
                  CandNome = sdr.GetValue(0).ToString(),
                  Vaga = sdr.GetValue(1).ToString(),
                  TotaisPontos = Convert.ToInt32(sdr.GetValue(2))
                }
            );
      }
      sqlconn.Close();
      return Ok(listaResultados);
    }
  }
}
