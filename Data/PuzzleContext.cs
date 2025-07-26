using Microsoft.EntityFrameworkCore;
using Puzzles.Models;

namespace Puzzles.Data
{
    public class PuzzleContext : DbContext
    {
        public PuzzleContext(DbContextOptions<PuzzleContext> options) : base(options)
        {

        }

        public DbSet<Puzzle> Puzzles { get; set; }
    }
}
