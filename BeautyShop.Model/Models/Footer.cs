using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Model.Models
{
    [Table("Footers")] //Maping toi bang Footers
    public class Footer
    {
        [Key] //khóa chính
        [MaxLength(50)]
        public string ID { set; get; }

        [Required] //bắt buộc phải nhập
        public string Content { set; get; }
    }
}
