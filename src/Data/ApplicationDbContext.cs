﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BES.Areas.Procurement.Models;

namespace BES.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet< BES.Models.Data.School> Schools {get;set;}
        public DbSet< BES.Models.Data.UC> UCs {get;set;}
        public DbSet< BES.Models.Data.Tehsil> Tehsils {get;set;}
        public DbSet< BES.Models.Data.District> Districts {get;set;}
        public DbSet< BES.Models.Data.Region> Regions {get;set; }
        public DbSet<BES.Models.Data.SchoolClass> SchoolClasses { get; set; }

        public DbSet<BES.Models.Data.BaselineGeneral> BaselineGenerals { get; set; }
        public DbSet<BES.Models.Data.BLEnrollment> BLEnrollments { get; set; }
        public DbSet<BES.Models.Data.BLFacilitiesInfo> BLFacilitiesInfoes { get; set; }
        public DbSet<BES.Models.Data.BLFeederDetail> BLFeederDetails { get; set; }
        public DbSet<BES.Models.Data.BLFeederSchool> BLFeederSchools { get; set; }
        public DbSet<BES.Models.Data.BLLandAvailable> BLLandAvailables { get; set; }
        public DbSet<BES.Models.Data.BLPTSMCInfo> BLPTSMCInfoes { get; set; }
        public DbSet<BES.Models.Data.BLTeacherDetail> BLTeacherDetails { get; set; }
        public DbSet<BES.Models.Data.BLTeacherPost> BLTeacherPosts { get; set; }
        public DbSet<BES.Models.Data.BLTeacherPresent> BLTeacherPresents { get; set; }
        public DbSet<BES.Models.Data.BLTeacherSection> BLTeacherSections { get; set; }
        public DbSet<BES.Models.Data.Contractor> Contractor { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<BES.Areas.Procurement.Models.ActivityDetail>().HasKey(table => new {
                table.ActivityID,
                table.StepID
            });
        }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Unit> Unit { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Project> Project { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Method> Method { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.ProcurementPlan> ProcurementPlan { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Step> Step { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Activity> Activity { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.ActivityDetail> ActivityDetail { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Lot> Lot { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.LotItem> LotItem { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.LotItemImage> LotItemImage { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Location> Location { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.Addendum> Addendum { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.AddendumDetail> AddendumDetail { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.SCManagement> SCManagement { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }
        //public DbSet<BES.Models.Data.>  { get; set; }


        public DbSet<BES.Areas.Procurement.Models.SCManagementItem> SCManagementItem { get; set; }
        public DbSet<BES.Areas.Procurement.Models.ModelViews.VLotItemDetail> VLotItemDetail { get; set; }
    }
}
