﻿using AutoMapper;
using LibApp.Data;
using LibApp.Dtos;
using LibApp.Models;
using LibApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected ApplicationDbContext context;
        protected IMapper mapper;
        public CustomerRepository(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IEnumerable<Customer> GetBooks() => context.Customers.Include(c => c.MembershipType);
        public Customer GetById(int id) => context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
        public void Delete(int id) => context.Customers.Remove(GetById(id));
        public void Save() => context.SaveChanges();
    }
}