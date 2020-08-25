﻿// <auto-generated />
using DataAccessTournament;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessTournament.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200824230905_matchAndWorkDayTable")]
    partial class matchAndWorkDayTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessTournament.Models.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayGoal")
                        .HasColumnType("int");

                    b.Property<int>("AwayPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HomeGoal")
                        .HasColumnType("int");

                    b.Property<int>("HomePlayerId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("WorkDayId")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("DataAccessTournament.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DataAccessTournament.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("DataAccessTournament.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TournamentId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("DataAccessTournament.Models.WorkDay", b =>
                {
                    b.Property<int>("WorkDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("WorkDayId");

                    b.ToTable("WorkDays");
                });
#pragma warning restore 612, 618
        }
    }
}
