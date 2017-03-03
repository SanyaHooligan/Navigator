using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class News
    {
        [Key]
        public Int32 NewsId { get; set; }

        [Display(Name="Заголовок")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Введите заголовок")]
        public String Header { get; set; }

        [Display(Name = "Текст новости")]
        [DataType(DataType.MultilineText)]
        public String Body { get; set; }

        [DataType(DataType.ImageUrl)]
        public String Image { get; set; }

        public DateTime Date { get { return DateTime.Now; } }
    }
}