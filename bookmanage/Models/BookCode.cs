using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace bookmanage.Models
{
    public class BookCode
    {
        [DisplayName("CodeType"),StringLength(100)]
        [Required(ErrorMessage = "此欄位必填")]
        public string CodeType { get; set; }

        [DisplayName("CodeId"), StringLength(200)]
        [Required(ErrorMessage = "此欄位必填")]
        public string CodeId { get; set; }

        [DisplayName("CodeType描述"), StringLength(400)]
        public string CodeTypeDesc { get; set; }

        [DisplayName("CodeId描述"), StringLength(400)]
        public string CodeName { get; set; }

        [DisplayName("建立時間"), StringLength(8)]
        public DateTime CreateDate { get; set; }

        [DisplayName("建立使用者"), StringLength(20)]
        public string CreateUser { get; set; }

        [DisplayName("修改時間"), StringLength(8)]
        public DateTime ModifyDate { get; set; }

        [DisplayName("修改使用者"), StringLength(20)]
        public string ModifyUser { get; set; }

    }
}