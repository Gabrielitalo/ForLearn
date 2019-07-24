using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
  public class CandidatosModel
  {
    public int Pk { get; set; }
    public int FkVaga { get; set; }
    public string Nome { get; set; }

  }
}