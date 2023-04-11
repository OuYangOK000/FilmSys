using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class Admin
    {
        //管理员表

        [Key]
        public string? Id { get; set; }//管理员编号
        [AllowNull]
        public string Name { get; set; }//管理员姓名
        [AllowNull]
        public string Login { get; set; }//登录名
        [AllowNull]
        public string Password { get; set; }//登录密码
        [AllowNull]
        public string State { get; set; }//状态
    }
}
