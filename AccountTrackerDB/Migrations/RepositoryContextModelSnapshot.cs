﻿// <auto-generated />
using System;
using AccountTrackerDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AccountTrackerDB.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AccountTrackerDB.AccountPersistence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("account_holder_name");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("account_id");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("account_name");

                    b.Property<decimal>("CurrentValue")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("current_value");

                    b.HasKey("Id");

                    b.ToTable("AccountPersistences");
                });

            modelBuilder.Entity("AccountTrackerDB.TransactionPersistence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("amount");

                    b.Property<int?>("SourceAccountId")
                        .HasColumnType("int");

                    b.Property<int?>("TargetAccountId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("transaction_id");

                    b.HasKey("Id");

                    b.HasIndex("SourceAccountId");

                    b.HasIndex("TargetAccountId");

                    b.ToTable("TransactionPersistences");
                });

            modelBuilder.Entity("AccountTrackerDB.TransactionPersistence", b =>
                {
                    b.HasOne("AccountTrackerDB.AccountPersistence", "SourceAccount")
                        .WithMany()
                        .HasForeignKey("SourceAccountId");

                    b.HasOne("AccountTrackerDB.AccountPersistence", "TargetAccount")
                        .WithMany()
                        .HasForeignKey("TargetAccountId");

                    b.Navigation("SourceAccount");

                    b.Navigation("TargetAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
