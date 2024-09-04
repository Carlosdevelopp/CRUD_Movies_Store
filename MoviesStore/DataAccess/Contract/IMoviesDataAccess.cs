﻿using DataAccess.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contract
{
    public interface IMoviesDataAccess
    {
        #region GET
        List<Movies> GetMovies();

        Movies GetMovie(int movieId);
        #endregion
    }
}