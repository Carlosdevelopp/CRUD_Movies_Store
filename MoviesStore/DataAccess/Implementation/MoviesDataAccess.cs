﻿using DataAccess.Contract;
using DataAccess.Implementation.Base;
using DataAccess.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class MoviesDataAccess : IMoviesDataAccess
    {
        private readonly ApplicationDbContext _dbContext; 

        public MoviesDataAccess(ApplicationDbContext dbContex)
        {
            _dbContext = dbContex;
        }

        #region GET
        //Get a record (Movies)
        public Movies GetMovie(int movieId)
        {
            Movies movie = (from u in _dbContext.Movies
                            where u.MovieId == movieId
                            select u).FirstOrDefault();

            return movie;
        }

        //Get a list of records (Movies)
        public List<Movies> GetMovies()
        {
            List<Movies> movies = (from u in _dbContext.Movies
                             select u).ToList();

            return movies;
        }

        //Get a record (MovieDetails)
        public Movies GetMovieDetails(int movieId)
        {
            Movies moviedetails = (from u in _dbContext.Movies
                                   where u.MovieId == movieId
                                   select u).Include(o => o.Awards)
                                            .Include(o => o.Genres)
                                            .FirstOrDefault();

            return moviedetails;
        }

        //Get a list of records (MoviesDetails)
        public List<Movies> GetMoviesDetails()
        {
            List<Movies> moviesdetails = (from u in _dbContext.Movies
                                          select u)
                                         .Include(o => o.Awards)
                                         .Include(o => o.Genres)
                                         .ToList();

            return moviesdetails;
        }
        #endregion

        #region POST
        public void InsertMovie(Movies movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
        }
        #endregion
    }
}
