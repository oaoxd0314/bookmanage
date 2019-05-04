using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace bookmanage.Models
{
    public class BookData
    {
        [DisplayName("書籍編號"), StringLength(4)]
        public int BookId { get; set; }

        [DisplayName("書籍名稱"), StringLength(400)]
        [Required(ErrorMessage = "此欄位必填")]
        public string BookName { get; set; }

        [DisplayName("類別代號"), StringLength(8)]
        [Required(ErrorMessage = "此欄位必填")]
        public string BookClassId { get; set; }

        [DisplayName("書籍作者")]
        [StringLength(60)]
        public string BookAuthor { get; set; }
        


        [DisplayName("書籍購買日期")]
        [StringLength(8)]
        public DateTime BookBoughtDate { get; set; }
        


        [DisplayName("出版商")]
        [StringLength(40)]
        public string BookPublisher { get; set; }
        

        [DisplayName("內容簡介")]
        [StringLength(2400)]
        public string BookNote { get; set; }
        

        [DisplayName("狀態")]
        [StringLength(1)]
        [Required(ErrorMessage = "此欄位必填")]
        public char BookStatus { get; set; }
        

        [DisplayName("書籍保管人")]
        [StringLength(24)]
        public string BookKeeper { get; set; }
        

        [DisplayName("建立時期")]
        [StringLength(8)]
        public DateTime CreateDate { get; set; }
        

        [DisplayName("建立使用者")]
        [StringLength(24)]
        public string CreateUser { get; set; }
        

        [DisplayName("修改時間")]
        [StringLength(8)]
        public DateTime ModifyDate { get; set; }

        [DisplayName("修改使用者"), StringLength(10)]
        public string ModifyUser { get; set; }
    }
}