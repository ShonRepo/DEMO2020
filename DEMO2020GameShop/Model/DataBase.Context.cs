﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEMO2020GameShop.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEMO2020Entities : DbContext
    {
        public DEMO2020Entities()
            : base("name=DEMO2020Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ageLimit> ageLimit { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<chatroom> chatroom { get; set; }
        public virtual DbSet<chatroomUser> chatroomUser { get; set; }
        public virtual DbSet<friends> friends { get; set; }
        public virtual DbSet<game> game { get; set; }
        public virtual DbSet<gameCategory> gameCategory { get; set; }
        public virtual DbSet<gamelib> gamelib { get; set; }
        public virtual DbSet<messageChatroom> messageChatroom { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<regionGame> regionGame { get; set; }
        public virtual DbSet<session> session { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<wallet> wallet { get; set; }
    }
}