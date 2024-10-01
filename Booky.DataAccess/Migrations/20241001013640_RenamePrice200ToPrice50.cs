using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RenamePrice200ToPrice50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price500",
                table: "Products",
                newName: "Price50");

            migrationBuilder.RenameColumn(
                name: "Price200",
                table: "Products",
                newName: "Price100");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ListPrice", "Price100", "Price50" },
                values: new object[] { "\\images\\product\\d80fb986-403b-4c98-8f62-18ae9f46163b.jpg", 450000.0, 370000.0, 390000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ListPrice", "Price100", "Price50" },
                values: new object[] { "\\images\\product\\9ef720f1-189a-45bf-9fc3-4e4075fbe1ae.jpg", 75000.0, 60000.0, 65000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price100", "Price50" },
                values: new object[] { "\\images\\product\\55164fe4-9d9e-4a74-9160-f684e93a23ab.jpg", 180000.0, 190000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price100", "Price50" },
                values: new object[] { "\\images\\product\\5aa4f1a5-b51e-4595-a9e9-81dd42971017.jpg", 280000.0, 290000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price50" },
                values: new object[] { "\\images\\product\\8025ea01-b070-4b9b-a113-991ef1b303f5.jpg", 130000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Price100", "Price50" },
                values: new object[] { "\\images\\product\\f4eb610b-1817-42ce-8569-e05d2160f28d.jpg", 100000.0, 110000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price50",
                table: "Products",
                newName: "Price500");

            migrationBuilder.RenameColumn(
                name: "Price100",
                table: "Products",
                newName: "Price200");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ListPrice", "Price200", "Price500" },
                values: new object[] { "", 490000.0, 350000.0, 300000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ListPrice", "Price200", "Price500" },
                values: new object[] { "", 85000.0, 65000.0, 60000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageUrl", "Price200", "Price500" },
                values: new object[] { "", 100000.0, 50000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageUrl", "Price200", "Price500" },
                values: new object[] { "", 250000.0, 230000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Price500" },
                values: new object[] { "", 100000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Price200", "Price500" },
                values: new object[] { "", 110000.0, 100000.0 });
        }
    }
}
