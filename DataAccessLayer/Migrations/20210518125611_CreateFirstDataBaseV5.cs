using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class CreateFirstDataBaseV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Users_UserId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Retweet_Tweets_TweetId",
                table: "Retweet");

            migrationBuilder.DropForeignKey(
                name: "FK_Retweet_Users_UserId",
                table: "Retweet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Retweet",
                table: "Retweet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Like",
                table: "Like");

            migrationBuilder.RenameTable(
                name: "Retweet",
                newName: "Retweets");

            migrationBuilder.RenameTable(
                name: "Like",
                newName: "Likes");

            migrationBuilder.RenameIndex(
                name: "IX_Retweet_UserId",
                table: "Retweets",
                newName: "IX_Retweets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Retweet_TweetId",
                table: "Retweets",
                newName: "IX_Retweets_TweetId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_UserId",
                table: "Likes",
                newName: "IX_Likes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_TweetId",
                table: "Likes",
                newName: "IX_Likes_TweetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Retweets",
                table: "Retweets",
                column: "RetweetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                column: "LikeId");

            migrationBuilder.CreateTable(
                name: "Followers",
                columns: table => new
                {
                    FollowersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => x.FollowersId);
                    table.ForeignKey(
                        name: "FK_Followers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Follows",
                columns: table => new
                {
                    FollowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.FollowId);
                    table.ForeignKey(
                        name: "FK_Follows_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Followers_UserId",
                table: "Followers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_UserId",
                table: "Follows",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Retweets_Tweets_TweetId",
                table: "Retweets",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Retweets_Users_UserId",
                table: "Retweets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Tweets_TweetId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Retweets_Tweets_TweetId",
                table: "Retweets");

            migrationBuilder.DropForeignKey(
                name: "FK_Retweets_Users_UserId",
                table: "Retweets");

            migrationBuilder.DropTable(
                name: "Followers");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Retweets",
                table: "Retweets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.RenameTable(
                name: "Retweets",
                newName: "Retweet");

            migrationBuilder.RenameTable(
                name: "Likes",
                newName: "Like");

            migrationBuilder.RenameIndex(
                name: "IX_Retweets_UserId",
                table: "Retweet",
                newName: "IX_Retweet_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Retweets_TweetId",
                table: "Retweet",
                newName: "IX_Retweet_TweetId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_UserId",
                table: "Like",
                newName: "IX_Like_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_TweetId",
                table: "Like",
                newName: "IX_Like_TweetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Retweet",
                table: "Retweet",
                column: "RetweetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Like",
                table: "Like",
                column: "LikeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Tweets_TweetId",
                table: "Like",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Users_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Retweet_Tweets_TweetId",
                table: "Retweet",
                column: "TweetId",
                principalTable: "Tweets",
                principalColumn: "TweetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Retweet_Users_UserId",
                table: "Retweet",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
