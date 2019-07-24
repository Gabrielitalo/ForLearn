using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
  public class CandidatosHabilidadesModel
  {
    public int Pk { get; set; }
    public int FkCand { get; set; }
    public int FkCadEmpresaH { get; set; }
  }
}