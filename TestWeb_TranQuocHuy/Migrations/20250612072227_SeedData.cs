using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWeb_TranQuocHuy.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Price", "Quantilty", "Title" },
                values: new object[,]
                {
                    { 1, "Huy", 32300m, 9, "Lập trình web" },
                    { 2, "Phu", 2300m, 12, "Cấu trúc dữ liệu và giải thuật" },
                    { 3, "Huy", 5300m, 5, "Kỹ thuật lập trình" },
                    { 4, "Phu", 3300m, 2, "Lập trình Java coer" },
                    { 5, "Huy", 1300m, 9, "Cơ sở dữ liệu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
