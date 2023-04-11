using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class Film
    {
        //电影表
        [Key]
        public string? Filmid { get; set; }//电影编号
        [AllowNull]
        public string Fname { get; set; }//电影名称
        [AllowNull]
        public string id { get; set; }//电影类型编号
        [AllowNull]
        public double Money { get; set; }//价格
        [AllowNull]
        public string KSTime { get; set; }//开始时间
        [AllowNull]
        public string JSTime { get; set; }//结束时间
        [AllowNull]
        public string FilmTid { get; set; }//电影厅编号
        [AllowNull]
        public string Remark { get; set; }//备注
    }
}
