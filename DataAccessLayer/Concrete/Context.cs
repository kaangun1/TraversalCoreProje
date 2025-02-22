using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

public class Context : IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=127.0.0.1;User Id=postgres;password=1234;Database=TraveersalDB");
        }

    public DbSet<About> Abouts { get; set; }
    public DbSet<About2> About2s { get; set; }
    public DbSet<Contact> Cotacts { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Feature2> Feature2s { get; set; }
    public DbSet<Guide> Guides { get; set; }
    public DbSet<Newsletter> Newsletters { get; set; }
    public DbSet<SubAbout> SubAbouts { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
    public DbSet<Comment> Comments  { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Account> Accounts { get; set; }

}