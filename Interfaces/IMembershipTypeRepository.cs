﻿using LibApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Interfaces
{
    public interface IMembershipTypeRepository
    {
        IEnumerable<MembershipType> GetBooks();
    }
}