using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kayitSistemis",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeTelefon = table.Column<int>(type: "int", nullable: false),
                    UyeMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeDogümTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kayitSistemis", x => x.UyeID);
                });

            migrationBuilder.CreateTable(
                name: "uyeCvs",
                columns: table => new
                {
                    CvID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeID = table.Column<int>(type: "int", nullable: false),
                    CvDosya = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uyeCvs", x => x.CvID);
                });

            migrationBuilder.CreateTable(
                name: "uyeSorülars",
                columns: table => new
                {
                    SorularID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeID = table.Column<int>(type: "int", nullable: false),
                    SoruBir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soruİki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruUc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruDort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruBes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruAlti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruYedi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruSekiz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruDokuz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoruOn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uyeSorülars", x => x.SorularID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kayitSistemis");

            migrationBuilder.DropTable(
                name: "uyeCvs");

            migrationBuilder.DropTable(
                name: "uyeSorülars");
        }
    }
}
