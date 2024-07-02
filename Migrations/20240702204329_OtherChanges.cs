using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealershipApp.Migrations
{
    /// <inheritdoc />
    public partial class OtherChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestedPeople_Cars_CarAdvertId",
                table: "InterestedPeople");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterestedPeople",
                table: "InterestedPeople");

            migrationBuilder.RenameTable(
                name: "InterestedPeople",
                newName: "InterestedPersons");

            migrationBuilder.RenameIndex(
                name: "IX_InterestedPeople_CarAdvertId",
                table: "InterestedPersons",
                newName: "IX_InterestedPersons_CarAdvertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterestedPersons",
                table: "InterestedPersons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestedPersons_Cars_CarAdvertId",
                table: "InterestedPersons",
                column: "CarAdvertId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestedPersons_Cars_CarAdvertId",
                table: "InterestedPersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterestedPersons",
                table: "InterestedPersons");

            migrationBuilder.RenameTable(
                name: "InterestedPersons",
                newName: "InterestedPeople");

            migrationBuilder.RenameIndex(
                name: "IX_InterestedPersons_CarAdvertId",
                table: "InterestedPeople",
                newName: "IX_InterestedPeople_CarAdvertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterestedPeople",
                table: "InterestedPeople",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestedPeople_Cars_CarAdvertId",
                table: "InterestedPeople",
                column: "CarAdvertId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
