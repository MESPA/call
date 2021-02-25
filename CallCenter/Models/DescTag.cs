using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CallCenter.Models
{
    public class DescTag
    {
        [Key]
        public int IdDescTag { get; set; }
        public string DescripcionTag { get; set; }
    }
}