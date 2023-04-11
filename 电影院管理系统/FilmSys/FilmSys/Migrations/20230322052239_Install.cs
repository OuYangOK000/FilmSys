using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmSys.Migrations
{
    /// <inheritdoc />
    public partial class Install : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentTypes",
                columns: table => new
                {
                    Did = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTypes", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Eid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idcard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wedlock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Politicid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Did = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jodlevelid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degindate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Eid);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Filmid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Money = table.Column<double>(type: "float", nullable: false),
                    KSTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmTid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Filmid);
                });

            migrationBuilder.CreateTable(
                name: "FilmTs",
                columns: table => new
                {
                    Tid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTs", x => x.Tid);
                });

            migrationBuilder.CreateTable(
                name: "FilmTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UInformations",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idcard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ULogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UPword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UInformations", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "UReserves",
                columns: table => new
                {
                    Cid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Call = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idcard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checkdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filmid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UReserves", x => x.Cid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "DepartmentTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "FilmTs");

            migrationBuilder.DropTable(
                name: "FilmTypes");

            migrationBuilder.DropTable(
                name: "UInformations");

            migrationBuilder.DropTable(
                name: "UReserves");
        }
    }
}
