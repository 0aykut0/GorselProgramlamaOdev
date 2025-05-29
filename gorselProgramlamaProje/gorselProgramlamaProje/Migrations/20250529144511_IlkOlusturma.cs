using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gorselProgramlamaProje.Migrations
{
    /// <inheritdoc />
    public partial class IlkOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciAdi = table.Column<string>(type: "TEXT", nullable: false),
                    SifreHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gorevler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    Baslik = table.Column<string>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TamamlandiMi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gorevler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukOzetler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ToplamPomodoroDakika = table.Column<int>(type: "INTEGER", nullable: false),
                    BasariliGorevSayisi = table.Column<int>(type: "INTEGER", nullable: false),
                    BasarisizGorevSayisi = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukOzetler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunlukOzetler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SilinenGorevler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrijinalId = table.Column<int>(type: "INTEGER", nullable: true),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    Baslik = table.Column<string>(type: "TEXT", nullable: false),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TamamlandiMi = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SilinenGorevler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SilinenGorevler_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SureSetleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: false),
                    CalismaSuresi = table.Column<int>(type: "INTEGER", nullable: false),
                    MolaSuresi = table.Column<int>(type: "INTEGER", nullable: false),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SureSetleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SureSetleri_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KullaniciAyarlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    SureSetiId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciAyarlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciAyarlari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciAyarlari_SureSetleri_SureSetiId",
                        column: x => x.SureSetiId,
                        principalTable: "SureSetleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PomodoroOturumlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KullaniciId = table.Column<int>(type: "INTEGER", nullable: false),
                    SureSetiId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PomodoroOturumlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PomodoroOturumlari_Kullanicilar_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PomodoroOturumlari_SureSetleri_SureSetiId",
                        column: x => x.SureSetiId,
                        principalTable: "SureSetleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_KullaniciId",
                table: "Gorevler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukOzetler_KullaniciId",
                table: "GunlukOzetler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciAyarlari_KullaniciId",
                table: "KullaniciAyarlari",
                column: "KullaniciId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciAyarlari_SureSetiId",
                table: "KullaniciAyarlari",
                column: "SureSetiId");

            migrationBuilder.CreateIndex(
                name: "IX_PomodoroOturumlari_KullaniciId",
                table: "PomodoroOturumlari",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_PomodoroOturumlari_SureSetiId",
                table: "PomodoroOturumlari",
                column: "SureSetiId");

            migrationBuilder.CreateIndex(
                name: "IX_SilinenGorevler_KullaniciId",
                table: "SilinenGorevler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_SureSetleri_KullaniciId",
                table: "SureSetleri",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorevler");

            migrationBuilder.DropTable(
                name: "GunlukOzetler");

            migrationBuilder.DropTable(
                name: "KullaniciAyarlari");

            migrationBuilder.DropTable(
                name: "PomodoroOturumlari");

            migrationBuilder.DropTable(
                name: "SilinenGorevler");

            migrationBuilder.DropTable(
                name: "SureSetleri");

            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
