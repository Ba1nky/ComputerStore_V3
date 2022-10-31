using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputerStore.Annotations;

namespace ComputerStore.Models
{
    [NotAllowedAttribute(ErrorMessage = "Неприпустимий продукт")]
    public class Product 
    {
        [ScaffoldColumn(false)]
        public long ProductId { get; set; }

        [Required(ErrorMessage = "Назва не повина бути пустною")]
        [Display(Name = "Назва")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Опис не повинен бути пустим")]
        [Display(Name = "Опис")]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "Ціна не повина бути пустною")]
        [MyPriceAttribute(ErrorMessage = "Ціна не повина бути від'ємною чи рівною нулеві")]
        [Display(Name = "Ціна")]
        public decimal? Price { get; set; } 

        [Required(ErrorMessage = "Категорія не повина бути пустною")]
        [Display(Name = "Категорія")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Purchase> Purchases { get; set; } = new List<Purchase>();

    }
}
