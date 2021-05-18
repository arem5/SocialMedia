using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateFirstDataBaseV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes");

            migrationBuilder.AlterColumn<int>(
                name: "TweetId",
                table: "Likes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes");

            migrationBuilder.AlterColumn<int>(
                name: "TweetId",
                table: "Likes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
