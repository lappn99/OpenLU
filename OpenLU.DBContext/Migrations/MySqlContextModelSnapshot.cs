﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenLU.DBContext;

namespace OpenLU.DBContext.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OpenLU.Models.GameModels+Character", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<uint>("Eyebrows")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("Eyes")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("FreeToPlay")
                        .HasColumnType("tinyint(1)");

                    b.Property<uint>("HairColor")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("HairStyle")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("Head")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("HeadColor")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("LH")
                        .HasColumnType("int unsigned");

                    b.Property<ulong>("LastLogin")
                        .HasColumnType("bigint unsigned");

                    b.Property<uint>("LastMapClone")
                        .HasColumnType("int unsigned");

                    b.Property<ushort>("LastMapInstance")
                        .HasColumnType("smallint unsigned");

                    b.Property<uint>("Mouth")
                        .HasColumnType("int unsigned");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<uint>("PantsColor")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("PantsStyle")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("RH")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("ShirtColor")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("ShirtStyle")
                        .HasColumnType("int unsigned");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<ushort>("Zone")
                        .HasColumnType("smallint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("OpenLU.Models.GameModels+InventoryItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("CharacterId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Equipped")
                        .HasColumnType("tinyint(1)");

                    b.Property<uint>("Lot")
                        .HasColumnType("int unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("OpenLU.Models.GameModels+User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("CurrentCharId")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Password")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OpenLU.Models.GameModels+Character", b =>
                {
                    b.HasOne("OpenLU.Models.GameModels+User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OpenLU.Models.GameModels+InventoryItem", b =>
                {
                    b.HasOne("OpenLU.Models.GameModels+Character", "Character")
                        .WithMany("Inventory")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
