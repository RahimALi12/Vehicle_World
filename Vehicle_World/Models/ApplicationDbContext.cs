﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Vehicle_World.Models
{
	public class ApplicationDbContext : IdentityDbContext
    {


      

      




        public ApplicationDbContext(DbContextOptions option) : base (option) { }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<CarDetail> CarDetails { get; set; }


        public DbSet<MakeType> MakeTypes { get; set; }
        public DbSet<ModelType> ModelTypes { get; set; }
        public DbSet<ConditionType> ConditionTypes { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }

        public DbSet<Contact> Contacts { get; set; }







        public DbSet<Chat> Chats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Buyer)
                .WithMany()
                .HasForeignKey(c => c.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Seller)
                .WithMany()
                .HasForeignKey(c => c.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
        }


    }
}
