﻿using EFCore_DBLibrary;
using InventoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataMigrator
{
    public class BuildItems
    {
        private readonly InventoryDbContext _context;
        private const string SEED_USER_ID = "31412031-7859-429c-ab21-c2e3e8d98042";
        public BuildItems(InventoryDbContext context)
        {
            _context = context;
        }

        public void ExecuteSeed()
        {
            if (_context.Items.Count() == 0)
            {
                _context.Items.AddRange(
                new Item() {
                    Name = "Batman Begins", CurrentOrFinalPrice =9.99m, Description = "You either die the hero or live long enough to see yourself become the villain",
                    IsOnSale = false, Notes = "", PurchasePrice =
                    23.99m, PurchasedDate = null, Quantity = 1000,
                    SoldDate = null, CreatedByUserId = SEED_USER_ID,
                    CreatedDate = DateTime.Now,
                    LastModifiedUserId = SEED_USER_ID,
                    IsDeleted = false, IsActive = true, Players = new
                    List<Player>() {
                    new Player() { CreatedDate = DateTime.
                    Now,IsActive = true,IsDeleted =
                    false,CreatedByUserId = SEED_USER_ID,
                    Description = "https://www.imdb.com/name/nm0000288/",Name= "Christian Bale",
                    LastModifiedUserId=SEED_USER_ID,
                    }
                    }
                },
                    new Item()
                    {
                        Name = "Inception",
                        CurrentOrFinalPrice = 7.99m,
                        Description = "You mustn't be afraid to dream a little bigger,darling",
                        IsOnSale = false,
                        Notes = "",
                        PurchasePrice =4.99m,
                        PurchasedDate = null,
                        Quantity = 1000,
                        SoldDate = null,
                        CreatedByUserId = SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        LastModifiedUserId = SEED_USER_ID,
                        IsDeleted = false,
                        IsActive = true,
                        Players = new
                        List<Player>() {
                        new Player() { CreatedDate = DateTime.
                        Now,IsActive = true,IsDeleted =
                        false,
                        CreatedByUserId = SEED_USER_ID,
                        Description = "https://www.imdb.com/name/nm0000138/",Name= "Leonardo DiCaprio",
                         LastModifiedUserId=SEED_USER_ID}
                        }
                    },
                    
                    new Item()
                    {
                        Name = "Remember the Titans",
                        CurrentOrFinalPrice= 3.99m,
                        Description = "Left Side, Strong Side",
                        IsOnSale = false,
                        Notes = "",
                        PurchasePrice =7.99m,
                        PurchasedDate = null,
                        Quantity = 1000,
                        SoldDate = null,
                        CreatedByUserId = SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        LastModifiedUserId = SEED_USER_ID,
                        IsDeleted = false,
                        IsActive = true,
                        Players = new
                    List<Player>() {
                    new Player() { CreatedDate = DateTime.
                    Now,IsActive = true,IsDeleted =
                    false,CreatedByUserId = SEED_USER_ID,
                    Description = "https://www.imdb.com/name/nm0000243/",Name= "Denzel Washington",
                     LastModifiedUserId=SEED_USER_ID}
                    }
                    },
                    new Item()
                    {
                        Name = "Star Wars: The Empire Strikes Back",
                        CurrentOrFinalPrice = 19.99m,
                        Description = "He will join us or die,master",
                        IsOnSale = false,
                        Notes = "",
                        PurchasePrice =35.99m,
                        PurchasedDate = null,
                        Quantity = 1000,
                        SoldDate = null,
                        CreatedByUserId = SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        LastModifiedUserId = SEED_USER_ID,
                        IsDeleted = false,
                        IsActive = true,
                        Players = new
                    List<Player>() {
                    new Player() { CreatedDate = DateTime.
                    Now,IsActive = true,IsDeleted =
                    false,CreatedByUserId = SEED_USER_ID,
                    Description = "https://www.imdb.com/name/nm0000434/",Name= "Mark Hamill",
                     LastModifiedUserId=SEED_USER_ID}
                    }
                    },
                    new Item()
                    {
                        Name = "Top Gun",
                        CurrentOrFinalPrice = 6.99m,
                        Description = "I feel the need, the need for speed!",
                        IsOnSale = false,
                        Notes = "",
                        PurchasePrice =8.99m,
                        PurchasedDate = null,
                        Quantity = 1000,
                        SoldDate = null,
                        CreatedByUserId = SEED_USER_ID,
                        CreatedDate = DateTime.Now,
                        LastModifiedUserId = SEED_USER_ID,
                        IsDeleted = false,
                        IsActive = true,
                        Players = new
                    List<Player>() {
                    new Player() { CreatedDate = DateTime.
                    Now,IsActive = true,IsDeleted =
                    false,CreatedByUserId = SEED_USER_ID,
                    Description = "https://www.imdb.com/name/nm0000129/",Name= "Tom Cruise",
                     LastModifiedUserId=SEED_USER_ID}
                    }
                    }
                    );
                _context.SaveChanges();
            }
        }
    }
}
