using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore_Tutorial_C35.Models {
    public class Order {

        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
