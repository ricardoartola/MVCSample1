using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCSample1.Models
{
    public class Calculator
    {
        [Display(Name ="Operand 1")]
        [Range(1, 100)]
        public int Operand1 { get; set; }
        
        [Display(Name = "Operand 2")]
        [Range(1,100)]
        public int Operand2 { get; set; }
        [Required]
        public Operator Operator { get; set; }

        public double? Result { get; set; }
    }
}