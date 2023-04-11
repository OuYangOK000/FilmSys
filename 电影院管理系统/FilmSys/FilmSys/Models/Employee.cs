using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FilmSys.Models
{
    public class Employee
    {
        //员工表

        [Key]
        public string? Eid { get; set; }//员工编号
        [AllowNull]
        public string Ename { get; set; }//员工姓名
        [AllowNull]
        public string Gender { get; set; }//性别
        [AllowNull]
        public string Birthday { get; set; }//出生日期
        [AllowNull]
        public string Idcard { get; set; }//身份证号
        [AllowNull]
        public string Wedlock { get; set; }//婚姻状况
        [AllowNull]
        public string Nation { get; set; }//民族
        [AllowNull]
        public string Nationplace { get; set; }//籍贯
        [AllowNull]
        public string Politicid { get; set; }//政治面貌
        [AllowNull]
        public string? Email { get; set; }//邮箱
        [AllowNull]
        public string Phone { get; set; }//电话号码
        [AllowNull]
        public string Address { get; set; }//联系地址
        [AllowNull]
        public string Did { get; set; }//所属部门
        [AllowNull]
        public string Jodlevelid { get; set; }//职称
        [AllowNull]
        public string Degindate { get; set; }//入职日期
        [AllowNull]
        public string? School { get; set; }//毕业院校

    
    }
}
