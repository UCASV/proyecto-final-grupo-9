using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID_19.ES.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstID",
                table: "INSTITUTION",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstID",
                table: "INSTITUTION");
        }
    }
}
