﻿using LibApp.Data;
using LibApp.Models;
using LibApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        protected ApplicationDbContext context;
        public GenreRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Genre> GetBooks() => context.Genre.ToList();
    }
}