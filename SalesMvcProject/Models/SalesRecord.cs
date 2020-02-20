using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesMvcProject.Models.Enums;

namespace SalesMvcProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public eSalesStatus MyProperty { get; set; }
    }
}
