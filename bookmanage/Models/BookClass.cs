using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookmanage.Models
{
    public class BookClass
    {
        [DisplayName("類別代號"), StringLength(8)]
        [Required(ErrorMessage = "此欄位必填"),]
        public string BookClassId { get; set; }

        [DisplayName("類別名稱")]
        [Required(ErrorMessage = "此欄位必填"), StringLength(120)]
        public string BookClassName { get; set; }

        [DisplayName("建立時間"), StringLength(8)]
        public DateTime CreateDate { get; set; }

        [DisplayName("建立使用者"), StringLength(24)]
        public string CreateUser { get; set; }

        [DisplayName("修改時間"), StringLength(8)]
        public DateTime ModifyDate { get; set; }

        [DisplayName("修改使用者"), StringLength(24)]
        public string ModifyUser { get; set; }

    }
}