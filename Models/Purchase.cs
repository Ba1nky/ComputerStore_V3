using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
