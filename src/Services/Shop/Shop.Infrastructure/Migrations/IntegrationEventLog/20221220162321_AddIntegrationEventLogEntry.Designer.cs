﻿// <auto-generated />
using System;
using IntegrationEventLogEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Shopping.Infrastructure.Migrations.IntegrationEventLog
{
    [DbContext(typeof(IntegrationEventLogContext))]
    [Migration("20221220162321_AddIntegrationEventLogEntry")]
    partial class AddIntegrationEventLogEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IntegrationEventLogEF.IntegrationEventLogEntry", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("event_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("creation_time");

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("event_type_name");

                    b.Property<int>("State")
                        .HasColumnType("integer")
                        .HasColumnName("state");

                    b.Property<int>("TimesSent")
                        .HasColumnType("integer")
                        .HasColumnName("times_sent");

                    b.Property<string>("TransactionId")
                        .HasColumnType("text");

                    b.HasKey("EventId");

                    b.ToTable("integration_event_log", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
