using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPost.Migrations
{
    /// <inheritdoc />
    public partial class AddViewCountAndUpvotesToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Upvotes",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Upvotes", "ViewCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Upvotes", "ViewCount" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Upvotes", "ViewCount" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Upvotes",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Posts");
        }
    }
}
