﻿// <auto-generated />
using System;
using GameWebAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameWebAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210103163245_AddedGameInviteSystem")]
    partial class AddedGameInviteSystem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("GameWebAPI.Entities.FriendRequest", b =>
                {
                    b.Property<string>("targetPlayerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("playerId")
                        .HasColumnType("TEXT");

                    b.HasKey("targetPlayerId");

                    b.ToTable("FriendsRequests");
                });

            modelBuilder.Entity("GameWebAPI.Entities.GameInvite", b =>
                {
                    b.Property<string>("invitedId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("hostId")
                        .HasColumnType("TEXT");

                    b.Property<string>("roomId")
                        .HasColumnType("TEXT");

                    b.HasKey("invitedId");

                    b.ToTable("GameInvites");
                });

            modelBuilder.Entity("GameWebAPI.Entities.Player", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("online")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("passwordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("passwordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("pwdResetToken")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("pwdResetTokenExpires")
                        .HasColumnType("TEXT");

                    b.HasKey("username");

                    b.HasIndex("email")
                        .IsUnique();

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GameWebAPI.Entities.PlayerFriend", b =>
                {
                    b.Property<string>("friendId")
                        .HasColumnType("TEXT");

                    b.Property<string>("playerId")
                        .HasColumnType("TEXT");

                    b.HasKey("friendId");

                    b.ToTable("FriendsList");
                });
#pragma warning restore 612, 618
        }
    }
}