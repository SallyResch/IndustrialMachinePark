using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndustrialMachinePark.Migrations
{
    /// <inheritdoc />
    public partial class changedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("327649de-9073-4030-a340-f5549c917702"), true, "The machine is ready to start", "Owen Large" },
                    { new Guid("596a46ce-43f5-4fab-aef3-6bbec0efe4b3"), false, "Waiting for cream to enter the bowl", "Beater machine" },
                    { new Guid("5afdc324-e363-4aeb-8e0c-a349eb6ab018"), false, "The machine is ready to start", "Owen small" },
                    { new Guid("783fb9b8-fe6a-4acb-90a7-8160ef14bf0d"), true, "The machine is ready to start", "Owen Medium" },
                    { new Guid("a2ca0ef7-b44f-4408-9034-3526a2a688fb"), false, "Latest rolling: marsipan", "Rolling machine" },
                    { new Guid("f43676c5-4a2e-4a85-9ec5-1c38ba446d66"), true, "Waiting for ingredients", "Dough Maker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("327649de-9073-4030-a340-f5549c917702"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("596a46ce-43f5-4fab-aef3-6bbec0efe4b3"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("5afdc324-e363-4aeb-8e0c-a349eb6ab018"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("783fb9b8-fe6a-4acb-90a7-8160ef14bf0d"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("a2ca0ef7-b44f-4408-9034-3526a2a688fb"));

            migrationBuilder.DeleteData(
                table: "Machines",
                keyColumn: "Id",
                keyValue: new Guid("f43676c5-4a2e-4a85-9ec5-1c38ba446d66"));

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
    }
}
