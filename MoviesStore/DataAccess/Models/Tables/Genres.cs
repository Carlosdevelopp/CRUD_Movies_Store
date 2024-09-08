﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Tables
{
    public class Genres
    {
        public int GenreId { get; set; }
        public string Genre { get; set; }
        public ICollection<Movies> Movies { get; set; }
    }
}
