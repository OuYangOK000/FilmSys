using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class FilmType
    {
        //电影类型表
        [Key]
        public string? Id { get; set; }//电影类型编号
        [AllowNull]
        public string FType { get; set; }//类型名称
    }
}
