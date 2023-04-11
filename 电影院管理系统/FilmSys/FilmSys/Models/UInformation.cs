using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class UInformation
    {
        //用户信息表①
        [Key]
        public string? Uid { get; set; }//用户编号
        [AllowNull]
        public string Name { get; set; }//用户姓名
        [AllowNull]
        public string Phone { get; set; }//电话
        [AllowNull]
        public string Idcard { get; set; }//身份证号码
        [AllowNull]
        public string Address { get; set; }//地址
        [AllowNull]
        public string ULogin { get; set; }//登录名
        [AllowNull]
        public string UPword { get; set; }//登录密码
        
    }
}
