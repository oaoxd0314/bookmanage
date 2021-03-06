﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookmanage.Models
{
    public class CodeService
    {
        /// <summary>
        /// 取得DB連線字串
        /// </summary>
        /// <returns></returns>
        private string GetDBConnectionString()
        {
            return
                System.Configuration.ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString.ToString();
        }

        /// <summary>
        /// 取得客戶資料
        /// </summary>
        /// <returns></returns>
        public List<BookData> GetBookData()
        {
            IList<BookData> list = new List<BookData>()
            {
                new BookData()
                {
                    BookId = 1,
                    BookName = "訂單2"
                },
                new BookData()
                {
                    OrderId = 2,
                    Name = "訂單2"
                }
            };
        }


        /// <summary>
        /// 取得codeTable的部分資料
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetCodeTable(string type)
        {
            DataTable dt = new DataTable();
            string sql = @"Select Distinct CodeVal As CodeName, CodeId As CodeID 
                           From dbo.CodeTable 
                           Where CodeType = @Type";
            using (SqlConnection conn = new SqlConnection(this.GetDBConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Type", type));
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(cmd);
                sqlAdapter.Fill(dt);
                conn.Close();
            }
            return this.MapCodeData(dt);
        }
        /// <summary>
        /// Maping 代碼資料
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private List<SelectListItem> MapCodeData(DataTable dt)
        {
            List<SelectListItem> result = new List<SelectListItem>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(new SelectListItem()
                {
                    Text = row["CodeId"].ToString() + '-' + row["CodeName"].ToString(),
                    Value = row["CodeId"].ToString()
                });
            }
            return result;
        }
    }
}