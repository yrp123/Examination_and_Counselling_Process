using Examination_and_Counselling_Process.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Examination_and_Counselling_Process.ContextDBConfig
{
    public class Exam_and_Counselling_DB_Context : IdentityDbContext<ApplicationUser>
    {

        public Exam_and_Counselling_DB_Context(DbContextOptions<Exam_and_Counselling_DB_Context> options) : base(options)
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
    }
