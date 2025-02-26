﻿using LibApp.Dtos;
using LibApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.ViewModels
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<GenreDto> Genres { get; set; }
        public string Title
        {
            get
            {
                if (Book != null && Book.Id != 0)
                {
                    return "Edit Book";
                }

                return "New Book";
            }
        }
    }
}
