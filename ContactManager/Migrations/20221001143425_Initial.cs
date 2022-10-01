using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Friend" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Acquintance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Family" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1507), "jilmehta52@gmail.com", "Jil", "Mehta", "Yahoo", "647-832-1825" },
                    { 2, 1, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1548), "nilmehta52@gmail.com", "Nil", "Mehta", "Google", "647-832-1825" },
                    { 3, 1, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1551), "nachiketamehta52@gmail.com", "Nachiketa", "Mehta", "Facebook", "647-832-1825" },
                    { 4, 1, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1553), "ajp52@gmail.com", "Arjun", "Pathak", "Yandex", "647-832-1825" },
                    { 5, 2, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1555), "dewangiben@gmail.com", "Dewangi", "Pathak", "Baidu", "647-832-1825" },
                    { 6, 2, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1558), "llbbhavya@gmail.com", "Bhavya", "Dave", "RSS", "647-832-1825" },
                    { 7, 2, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1560), "zansikirani@gmail.com", "Bhakti", "Dave", "Zhansi", "647-832-1825" },
                    { 8, 2, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1563), "itmeab@gmail.com", "Aakangsha", "Borisagar", "GujjuGarba", "647-832-1825" },
                    { 9, 3, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1565), "bbdm@gmail.com", "Bhaumik", "Prajapati", "IndianOcean", "647-832-1825" },
                    { 10, 3, new DateTime(2022, 10, 1, 10, 34, 25, 361, DateTimeKind.Local).AddTicks(1567), "prpjdksh@gmail.com", "Prajapati", "Daksh", "Shrushti", "647-832-1825" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
