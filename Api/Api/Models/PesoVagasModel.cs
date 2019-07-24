using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
  public class PesoVagasModel
  {
    public int Pk { get; set; }
    public int FkVaga { get; set; }
    public int FkCadEmp { get; set; }
    public int Peso { get; set; }
  }
}