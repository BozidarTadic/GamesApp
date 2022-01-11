using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesApp.Migrations
{
    public partial class Games2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Game",
                type: "bigint",
                fixedLength: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(450)",
                oldFixedLength: true)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "GameId",
                table: "Achievements",
                type: "bigint",
                fixedLength: true,
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(450)",
                oldFixedLength: true,
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Achievements",
                type: "bigint",
                fixedLength: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(450)",
                oldFixedLength: true)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Game",
                type: "nchar(450)",
                fixedLength: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true)
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "GameId",
                table: "Achievements",
                type: "nchar(450)",
                fixedLength: true,
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true,
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Achievements",
                type: "nchar(450)",
                fixedLength: true,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
