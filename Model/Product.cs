using System.ComponentModel.DataAnnotations;

namespace ProductOrder.Model
{
    public class Product
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public string Description { get; set; }
    }
}
