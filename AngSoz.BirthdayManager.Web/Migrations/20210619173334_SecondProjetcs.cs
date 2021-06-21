using Microsoft.EntityFrameworkCore.Migrations;

namespace AngSoz.BirthdayManager.Web.Migrations
{
    public partial class SecondProjetcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Pessoas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Pessoas");
        }
    }
}
