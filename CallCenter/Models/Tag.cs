using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CallCenter.Models
{
    public class Tag
    {
        [Key]
        public int IdTag { get; set; }
        public string Otros { get; set;}
        public string descripcion { get; set; }
        public string tema { get; set; }

    }
}