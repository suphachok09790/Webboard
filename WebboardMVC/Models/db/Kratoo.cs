using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebboardMVC.Models.db
{
    public partial class Kratoo
    {
        public Kratoo()
        {
            Comments = new HashSet<Comment>();
        }

        public int Kid { get; set; }

        [Required(ErrorMessage ="กรุณาป้อนคำถามก่อน")]
        [Display(Name ="ตั้งคำถาม")]
        [StringLength(100, MinimumLength =10, ErrorMessage = "กรุณาตั้งคำถามใช้ตัวอักษรตั้งแต่ 10-100 ตัวอักษร")]
        public string KratooTopic { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรายละเอียดคำถามก่อน")]
        [Display(Name = "รายละเอียด")]
        [StringLength(255 ,MinimumLength = 10, ErrorMessage = "กรุณาตั้งรายละเอียดคำถามใช้ตัวอักษรตั้งแต่ 10-255 ตัวอักษร")]
        public string KratooDetails { get; set; }

        [Display(Name = "หมวด")]
        public int CategoryId { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? ViewCount { get; set; }
        public int? ReplyCount { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อผู้ตั้งกระทู้ก่อน")]
        [Display(Name = "ผู้ตั้งกระทู้")]
        public string UserName { get; set; }

        public string UserIp { get; set; }
        public bool? IsShow { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
