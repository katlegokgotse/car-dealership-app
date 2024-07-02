using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDealershipApp.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestedPeople_Cars_CarsCarId",
                table: "InterestedPeople");

            migrationBuilder.DropIndex(
                name: "IX_InterestedPeople_CarsCarId",
                table: "InterestedPeople");

            migrationBuilder.DropColumn(
                name: "CarsCarId",
                table: "InterestedPeople");

            migrationBuilder.CreateIndex(
                name: "IX_InterestedPeople_CarAdvertId",
                table: "InterestedPeople",
                column: "CarAdvertId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestedPeople_Cars_CarAdvertId",
                table: "InterestedPeople",
                column: "CarAdvertId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestedPeople_Cars_CarAdvertId",
                table: "InterestedPeople");

            migrationBuilder.DropIndex(
                name: "IX_InterestedPeople_CarAdvertId",
                table: "InterestedPeople");

            migrationBuilder.AddColumn<int>(
                name: "CarsCarId",
                table: "InterestedPeople",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InterestedPeople_CarsCarId",
                table: "InterestedPeople",
                column: "CarsCarId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestedPeople_Cars_CarsCarId",
                table: "InterestedPeople",
                column: "CarsCarId",
                principalTable: "Cars",
                principalColumn: "CarId");
        }
    }
}
