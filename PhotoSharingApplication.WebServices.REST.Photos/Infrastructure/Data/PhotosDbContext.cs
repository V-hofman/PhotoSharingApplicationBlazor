using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhotoSharingApplication.Shared.Entities;

namespace PhotoSharingApplication.WebServices.REST.Photos.Infrastructure.Data
{
    public class PhotosDbContext : DbContext
    {

        public DbSet<Photo> Photos { get; set; }

        public PhotosDbContext(DbContextOptions<PhotosDbContext> options) : base(options) { }

        private void ConfigurePhoto(EntityTypeBuilder<Photo> builder)
        {
            builder.ToTable("Photos");

            builder.Property(photo => photo.Title)
                .IsRequired(true)
                .HasMaxLength(255);
        }
    }
}
