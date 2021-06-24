namespace NguyenTienLong_1811060449_lab06.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("book")]
    public partial class book
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Tieu de khong duoc de trong")]
        [StringLength(100,ErrorMessage = " tieu de khong qua 100 ki tu")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mo ta khong duoc de trong")]
        [StringLength(255)]
        public string Description { get; set; }
        [Required(ErrorMessage = "tac gia khong duoc de trong")]
        [StringLength(30,ErrorMessage ="ten tac gia khong qua 30 ki tu")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Hinh anh khong duoc de trong")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Gia khong duoc de trong")]
        [Range(1000,1000000,ErrorMessage =" gia sach tu 1,000 - 1,000,000 VND")]
        public int? Price { get; set; }
    }
}
