using System;
using MVcMovie.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVcMovie.Enumerations;

namespace MVcMovie.Data.MVcMovieConfiguration
{
    public class MVcMovieConfiguration:IEntityTypeConfiguration<Movie>{
        public void Configure (EntityTypeBuilder<Movie> builder)
        {
            builder.Property(a => a.Genre).HasConversion(b => b.ToString(), b => Enum.Parse<Genre>(b));
        }
    }
}