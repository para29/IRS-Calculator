using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
  public class IRS_Area_Nivel
  {
    [Key]
    public int NivelId { get; set; }
    public int AreaId { get; set; }
  }
}
