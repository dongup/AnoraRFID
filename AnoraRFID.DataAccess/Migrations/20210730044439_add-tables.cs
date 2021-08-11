using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnoraRFID.DataAccess.Migrations
{
    public partial class addtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "Logs",
                newName: "UPDATETED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Logs",
                newName: "UPDATED_DATE");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Logs",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Logs",
                newName: "CREATED_USER_ID");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Logs",
                newName: "DELETED_DATE");

            migrationBuilder.AddColumn<DateTime>(
                name: "CREATED_DATE",
                table: "Logs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CONFIG",
                columns: table => new
                {
                    CONFIG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KEY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VALUE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONFIG", x => x.CONFIG_ID);
                });

            migrationBuilder.CreateTable(
                name: "INVENTORY",
                columns: table => new
                {
                    IVENTORY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IVENTORY_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IVENTORY_SEQ = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    REF_DOC_NO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    INVENTORY_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    INVENTORY_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái xử lý: 1 - chờ xử lý; 2 - đã hoàn thành"),
                    COMPLETE_USER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTORY", x => x.IVENTORY_ID);
                });

            migrationBuilder.CreateTable(
                name: "INVENTORY_DTL",
                columns: table => new
                {
                    DTL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INVENTORY_ID = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    COMPLETE_USER = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái xử lý: 1 - Tìm thấy; 2 - Không tìm thấy"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTORY_DTL", x => x.DTL_ID);
                });

            migrationBuilder.CreateTable(
                name: "MODEL",
                columns: table => new
                {
                    MODEL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODEL_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODEL", x => x.MODEL_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRODUCT_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRODUCT_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EPC = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MODEL_ID = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ARTICLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRODUCT_SIZE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRODUCT_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái của giầy: 1 - Available; 2 - NotAvailable; 3 - OnHold"),
                    SAMPLE_NO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRODUCT_CUSTODIAN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LR = table.Column<int>(type: "int", nullable: false, comment: "Bên của giầy: 1 - Left; 2 - Right"),
                    PRODUCT_LOCATION = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRODUCT_DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DEV_TEAM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DEV_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_SEASON = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_TDCODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COLOR_NAME = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SAMPLE_REQUEST = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SAMPLE_SIZE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_GENDER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMPLETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRODUCT_WHQDEVELOPER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UPPER_MATERIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_MSMATERIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OUTSOLE_MATERIAL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LAST_ID = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_PATTERN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PRODUCT_STLFILE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    INPUT_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    REF_DOC_NO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    REF_DOC_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PAIR_CODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.PRODUCT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_ALTER",
                columns: table => new
                {
                    ALERT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    EPC = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ALERT_IP = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ALERT_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ALERT_FREQ = table.Column<int>(type: "int", nullable: false),
                    ALERT_CONF_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái xử lý: 1 - chưa xử lý; 2 - đã xử lý"),
                    ALERT_CONF_REASON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALERT_CONF_USER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALERT_CONF_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_ALTER", x => x.ALERT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_IO",
                columns: table => new
                {
                    IO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IO_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái của inout: 1 - chưa trả; 2 - đã trả"),
                    IO_REASON = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IO_DEPART = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    REF_DOC_NO = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    REF_DOC_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_IO", x => x.IO_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_IO_DTL",
                columns: table => new
                {
                    IO_DTL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IO_ID = table.Column<int>(type: "int", nullable: false),
                    IO_DTL_EXT = table.Column<int>(type: "int", nullable: false),
                    PRODUCT_ID = table.Column<int>(type: "int", nullable: false),
                    IO_GET_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IO_RET_TIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IO_GET_USER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IO_RET_USER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IO_GET_NOTE = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IO_RET_NOTE = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    IO_GET_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái giầy lấy: 1 - Ok; 2 - không ok"),
                    IO_RET_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái giầy trả: 1 - Ok; 2 - không ok"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_IO_DTL", x => x.IO_DTL_ID);
                });

            migrationBuilder.CreateTable(
                name: "RFID_TAG",
                columns: table => new
                {
                    RFID_TAG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPC = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TAG_STATUS = table.Column<int>(type: "int", nullable: false, comment: "Trạng thái xử lý: 1 - Sẵn sàng; 2 - Bị hủy"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CREATED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UPDATETED_USER_ID = table.Column<int>(type: "int", nullable: false),
                    DELETED_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IS_DELETED = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFID_TAG", x => x.RFID_TAG_ID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "3b62dea4-4f10-4d15-a2ad-afc66399dd72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "511ec17b-4b37-4416-be77-5ed1464c30e4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONFIG");

            migrationBuilder.DropTable(
                name: "INVENTORY");

            migrationBuilder.DropTable(
                name: "INVENTORY_DTL");

            migrationBuilder.DropTable(
                name: "MODEL");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "PRODUCT_ALTER");

            migrationBuilder.DropTable(
                name: "PRODUCT_IO");

            migrationBuilder.DropTable(
                name: "PRODUCT_IO_DTL");

            migrationBuilder.DropTable(
                name: "RFID_TAG");

            migrationBuilder.DropColumn(
                name: "CREATED_DATE",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "UPDATETED_USER_ID",
                table: "Logs",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "UPDATED_DATE",
                table: "Logs",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "Logs",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "DELETED_DATE",
                table: "Logs",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "CREATED_USER_ID",
                table: "Logs",
                newName: "CreatedUserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "4f892fb6-6383-4230-9e7a-7b28bff3540c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "9f1b98a6-d8dd-4743-9b8e-a317a6e16c0c");
        }
    }
}
