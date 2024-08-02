using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoAccesso.Core.Domain.Entities
{
    public class Weather
    {
        public int ID { get; set; }
        [ForeignKey("ProtectedArea")]
        public int ProtectedAreaID { get; set; }
        public ProtectedArea ProtectedArea { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Forecast { get; set; }
        public bool Alert { get; set; }
        public string AlertDescription { get; set; }
    }
}
