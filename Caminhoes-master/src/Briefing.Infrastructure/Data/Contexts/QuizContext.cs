using caminhoes.Domain.Entities;
using caminhoes.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace caminhoes.Infrastructure.Data.Contexts
{
    public class QuizContext : BaseDbContext
    {
        public QuizContext()
        {

        }
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source=wdb4.my-hosting-panel.com;Initial Catalog=asocial1_caminhoes;Persist Security Info=True;User ID=asocial1_odair;Password=Socialmente@2021")
                    .UseLazyLoadingProxies(false);
            }

            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
