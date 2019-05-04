using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookmanage.Models
{
    public class MemberM
    {
        [DisplayName("人員編號"), StringLength(24)]
        [Required(ErrorMessage = "此欄位必填")]
        public string UserId { get; set; }

        [DisplayName("中文名稱"), StringLength(100)]
        public string UserCName { get; set; }

        [DisplayName("英文名稱"), StringLength(100)]
        public string UserEName { get; set; }
        

        [DisplayName("建立時間"), StringLength(8)]
        public DateTime CreateDate { get; set; }

        [DisplayName("建立使用者"), StringLength(24)]
        public string CreateUser { get; set; }

        [DisplayName("修改時間"), StringLength(8)]
        public DateTime ModifyDate { get; set; }

        [DisplayName("修改使用者"), StringLength(100)]
        public string ModifyUser { get; set; }

    }
}