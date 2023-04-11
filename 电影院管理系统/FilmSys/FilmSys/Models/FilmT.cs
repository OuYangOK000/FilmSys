using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class FilmT
    {
        //电影厅表
        [Key]
        public string? Tid { get; set; }//电影厅编号
        [AllowNull]
        public string TName { get; set; }//电影厅名称
        [AllowNull]
        public string Number { get; set; }//座位数量
        [AllowNull]
        public string State { get; set; }//是否开厅
    }
}
