using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Tutorial_C35.Models {
    
    public class Customer {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "decimal(9,2)")]
        public decimal Sales { get; set; }
        public DateTime Updated { get; set; }

    }
}
