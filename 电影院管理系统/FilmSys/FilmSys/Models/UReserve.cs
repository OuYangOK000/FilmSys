using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class UReserve
    {
        //用户预定表②
        [Key]
        public string? Cid { get; set; }//预定编号
        [AllowNull]
        public string Call { get; set; }//电话
        [AllowNull]
        public string Address { get; set; }//地址
        [AllowNull]
        public string Idcard { get; set; }//身份证
        [AllowNull]
        public string Checkdate { get; set; }//预定日期
        [AllowNull]
        public string Filmid { get; set; }//电影编号
        [AllowNull]
        public string Uid { get; set; }//用户编号
    }
}
