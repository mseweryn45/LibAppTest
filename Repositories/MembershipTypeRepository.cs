﻿using LibApp.Data;
using LibApp.Models;
using LibApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Repositories
{
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        protected ApplicationDbContext context;
        public MembershipTypeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<MembershipType> GetBooks() => context.MembershipTypes.ToList();
    }
}