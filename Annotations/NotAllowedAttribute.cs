using ComputerStore.Models;
using System.ComponentModel.DataAnnotations;

namespace ComputerStore.Annotations
{
    public class NotAllowedAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Product product = value as Product;

            if (product.Name == "Основи с++" && product.Price > 550)
            {
                return false;
            }
            return true;
        }
    }

}

