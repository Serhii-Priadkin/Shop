using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Enter name")]
        [StringLength(20)]
        [Required(ErrorMessage = "Max length is 20 symbols")]
        public string name { get; set; }

        [Display(Name = "Enter surname")]
        [StringLength(20)]
        [Required(ErrorMessage = "Max length is 20 symbols")]
        public string surname { get; set; }

        [Display(Name = "Enter address")]
        [StringLength(100)]
        [Required(ErrorMessage = "Max length is 100 symbols")]
        public string address { get; set; }

        [Display(Name = "Enter phone")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Max length is 20 symbols")]
        public string phone { get; set; }

        [Display(Name = "Enter email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required(ErrorMessage = "Max length is 50 symbols")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
