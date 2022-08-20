using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EShoppingEntity
{
    public class SalesVoucher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoucherId { get; set; }
        [Required]
        public string VoucherNumber { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [ForeignKey("Product")]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double TaxPerc { get; set; }
        [Required]
        public double TaxAmnt { get; set; }
        [Required]
        public double Total { get; set; }

    }
}
