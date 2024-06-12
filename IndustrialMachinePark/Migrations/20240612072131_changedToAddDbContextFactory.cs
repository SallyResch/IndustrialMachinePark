using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndustrialMachinePark.Migrations
{
    /// <inheritdoc />
    public partial class changedToAddDbContextFactory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("1b90bf7b-ee60-4c03-8434-8968355a76a2"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("3f939efe-71c2-4454-9f52-bac1efd85359"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("5ca63d37-73c8-4d91-bf82-e75fdfdc4f69"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("78d1d32f-3342-4b6f-8937-fcd4942505ec"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("a4d5881b-0ded-46de-93f8-4285e27cc6f2"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("e69aa2f3-71d2-4823-8c44-c8189a4c3b1b"));

            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "Id", "IsOnline", "LatestData", "Name" },
                values: new object[,]
                {
                    { new Guid("270631ea-5455-44fc-92df-b312304fea2a"), false, "Waiting for cream to enter the bowl", "Beater machine" },
                    { new Guid("2dab9f70-f6e8-4df0-b99f-6a93219335e3"), false, "The machine is ready to start", "Owen small" },
                    { new Guid("6da5027b-e01e-4538-90df-b4b7dfbb1257"), false, "The machine is ready to start", "Owen Large" },
                    { new Guid("8708e4a7-43a8-4f88-965f-fe5b88295d66"), false, "The machine is ready to start", "Owen Medium" },
                    { new Guid("bcdacd6c-02ce-4dd8-a82f-d641dfbabf02"), false, "Latest rolling: marsipan", "Rolling machine" },
                    { new Guid("be822a24-a68e-4658-ac6f-f1b2589434a0"), true, "Waiting for ingredients", "Dough Maker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("270631ea-5455-44fc-92df-b312304fea2a"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("2dab9f70-f6e8-4df0-b99f-6a93219335e3"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("6da5027b-e01e-4538-90df-b4b7dfbb1257"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("8708e4a7-43a8-4f88-965f-fe5b88295d66"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("bcdacd6c-02ce-4dd8-a82f-d641dfbabf02"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("be822a24-a68e-4658-ac6f-f1b2589434a0"));

            migrationBuilder.InsertData(
                table: "Machines",
                columns: new[] { "Id", "IsOnline", "LatestData", "Name" },
                values: new object[,]
                {
                    { new Guid("1b90bf7b-ee60-4c03-8434-8968355a76a2"), true, "Waiting for ingredients", "Dough Maker" },
                    { new Guid("3f939efe-71c2-4454-9f52-bac1efd85359"), false, "The machine is ready to start", "Owen Medium" },
                    { new Guid("5ca63d37-73c8-4d91-bf82-e75fdfdc4f69"), false, "Latest rolling: marsipan", "Rolling machine" },
                    { new Guid("78d1d32f-3342-4b6f-8937-fcd4942505ec"), false, "Waiting for cream to enter the bowl", "Beater machine" },
                    { new Guid("a4d5881b-0ded-46de-93f8-4285e27cc6f2"), false, "The machine is ready to start", "Owen Large" },
                    { new Guid("e69aa2f3-71d2-4823-8c44-c8189a4c3b1b"), false, "The machine is ready to start", "Owen small" }
                });
        }
    }
}
