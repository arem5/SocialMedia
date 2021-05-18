using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateFirstDataBaseV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like");

            migrationBuilder.AlterColumn<int>(
                name: "TweetId",
                table: "Like",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like");

            migrationBuilder.AlterColumn<int>(
                name: "TweetId",
                table: "Like",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
