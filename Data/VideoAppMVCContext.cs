using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideoAppMVC.Models;

namespace VideoAppMVC.Data
{
    public class VideoAppMVCContext : DbContext
    {
        public VideoAppMVCContext (DbContextOptions<VideoAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<VideoAppMVC.Models.Film> Film { get; set; } = default!;
    }
}
