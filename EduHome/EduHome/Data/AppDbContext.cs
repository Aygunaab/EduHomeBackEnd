using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventSpeakers> EventSpeakers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TestimonialSlider> TestimonialSliders { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SocialLink>SocialLinks { get; set; }
        public DbSet<Skill>Skills { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<BlogComment> BlogComments{ get; set; }
        public DbSet<Tag> Tags { get; set; }


    }
}
