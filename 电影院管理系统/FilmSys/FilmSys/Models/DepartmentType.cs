using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class DepartmentType
    {
        //部门类型表

        [Key]
        public string? Did { get; set; }//部门编号
        [AllowNull]
        public string DType { get; set; }//部门名称
    }
}
