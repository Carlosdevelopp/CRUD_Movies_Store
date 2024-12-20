﻿using Infrastructure.Contract;
using Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MoviesStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesInfrastructure _moviesInfrastructure;
        public MoviesController(IMoviesInfrastructure moviesInfrastructure)
        {
            _moviesInfrastructure = moviesInfrastructure;
        }

        #region GET
        /// <summary>
        /// Get a movie by its ID
        /// </summary>
        /// <param name="movieId">ID of movie</param>
        /// <returns>Object of movie</returns>
        /// <remarks>
        /// Request:
        ///
        ///     GET /api/Movies/GetMovie
        ///     {
        ///         "tituloMovie": "string",
        ///         "descriptionMovie": "string",
        ///         "runningMovie": int,
        ///         "releaseMovie": dataTime,
        ///         "genreId": int,
        ///         "awardId": int
        ///     }
        /// </remarks>
        /// <response code="201">Successful operation and return movie object</response>
        /// <response code="400">Client error</response>
        [HttpGet("GetMovie")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMovie(int movieId)
        {
            try
            {
                return Ok(_moviesInfrastructure.GetMovie(movieId));
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }

        /// <summary>
        /// Get a list all movies.
        /// </summary>
        /// <returns>A list objetos of movies.</returns>
        /// <remarks>
        ///  Request:
        ///     
        ///         GET /api/Movies/GetMovies
        ///         {
        ///            "titleMovie": "string",
        ///            "descriptionMovie": "string",
        ///            "runningMovie": int,
        ///            "releaseMovie": "datatime",
        ///            "genre": int,
        ///            "award": int
        ///         }
        /// </remarks>
        /// <response code="201">Operation successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetMovies")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMovies()
        {
            try
            {
                return Ok(_moviesInfrastructure.GetMovies());
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }

        /// <summary>
        /// Get a moviedetails by its ID
        /// </summary>
        /// <param name="movieId">ID of moviedetails</param>
        /// <returns>Object of moviedetails</returns>
        /// <remarks>
        /// Request:
        ///
        ///     GET /api/Movies/GetMovieDetails
        ///     {
        ///         "tituloMovie": "string",
        ///         "descriptionMovie": "string",
        ///         "runningMovie": string,
        ///         "releaseMovie": string,
        ///         "genreId": string,
        ///         "awardId": string
        ///     }
        /// </remarks>
        /// <response code="201">Successful operation and return movieDetails object</response>
        /// <response code="400">Client error</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetMovieDetails")]
        public IActionResult GetMovieDetails(int movieId) 
        {
            try
            {
                return Ok(_moviesInfrastructure.GetMovieDetails(movieId));
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }

        /// <summary>
        /// Get a list all moviesdetails.
        /// </summary>
        /// <returns>A list objects of movies.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetMoviesDetails
        ///         {
        ///            "titleMovie": "string",
        ///            "descriptionMovie": "string",
        ///            "runningMovie": string,
        ///            "releaseMovie": "string",
        ///            "genre": string,
        ///            "award": string
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful and returns the list of moviesdetails.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetMoviesDetails")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMoviesDetails()
        {
            try
            {
                return Ok(_moviesInfrastructure.GetMoviesDetails());
            }
            catch (Exception)
            {

                return BadRequest("error");
            }
        }

        /// <summary>
        /// Get a award by its ID.
        /// </summary>
        /// <returns>ID of Awards.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetAward
        ///         {
        ///             "awardId": int,
        ///             "awardTitle": "string"
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetAward")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAward(int awardId)
        {
            try
            {
                return Ok(_moviesInfrastructure.GetAward(awardId));
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        /// <summary>
        /// Get a list all genres.
        /// </summary>
        /// <returns>A list objects of genres.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetGenres
        ///         {
        ///             "genreMovie": "string"
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetGenres")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGenres()
        {
            try
            {
                return Ok(_moviesInfrastructure.GetGenres());    
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        /// <summary>
        /// Get a genre by its ID.
        /// </summary>
        /// <returns>ID of Genres.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetGenre
        ///         {
        ///             "genreMovie": "string"
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetGenre")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGenre(int genreId)
        {
            try
            {
                return Ok(_moviesInfrastructure.GetGenre(genreId));
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }


        /// <summary>
        /// Get a list all actors.
        /// </summary>
        /// <returns>A list objects of actors.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetActors
        ///         {
        ///             "fulllNameActor": "string"
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetActors")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetActors()
        {
            try
            {
                return Ok(_moviesInfrastructure.GetActors());
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        /// <summary>
        /// Get a actor by its ID.
        /// </summary>
        /// <returns>A list objects of actor.</returns>
        /// <remarks>
        ///     Ejemplo de solicitud:
        ///     
        ///         GET /api/Movies/GetActor
        ///         {
        ///             "fulllNameActor": "string"
        ///         }
        /// </remarks>
        /// <response code="201">Operation Successful.</response>
        /// <response code="400">Client error.</response>
        [HttpGet("GetActor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetActor(int actorId)
        {
            try
            {
                return Ok(_moviesInfrastructure.GetActor(actorId));
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }
        #endregion

        #region POST
        /// <summary>
        /// Insert a movie into the database.
        /// </summary>
        /// <param name="moviesInsertDTO">Object to insert.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     POST /api/Movies/InsertMovie
        ///     {
        ///         "titleMovie": "string",
        ///         "descriptionMovie": "string",
        ///         "releaseMovie": "datatime",
        ///         "runningTimeMovie": int,
        ///         "genreId": int,
        ///         "awardId": int
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Successful operation.</response>
        /// <response code="400">Client error.</response>
        [HttpPost("InsertMovie")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InsertMovie(MoviesInsertDTO moviesInsertDTO)
        {
            try
            {
                _moviesInfrastructure.InsertMovie(moviesInsertDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        /// <summary>
        /// Insert a genre into the database.
        /// </summary>
        /// <param name="genresInsertDTO">Object to insert.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     POST /api/Movies/InsertGenre
        ///     {
        ///         "genre": "string"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Successful operation.</response>
        /// <response code="400">Client error.</response>
        [HttpPost("InsertGenre")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InsertGenre(GenresInsertDTO genresInsertDTO)
        {
            try
            {
                _moviesInfrastructure.InsertGenre(genresInsertDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }

        /// <summary>
        /// Insert a award into the database.
        /// </summary>
        /// <param name="awardInsertDTO">Object to insert.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     POST /api/Movies/InsertAward
        ///     {
        ///         "awardTitle": "string"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Successful operation.</response>
        /// <response code="400">Client error.</response>
        [HttpPost("InsertAward")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InsertAward(AwardsInsertDTO awardInsertDTO)
        {
            try
            {
                _moviesInfrastructure.InsertAward(awardInsertDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }

        /// <summary>
        /// Insert a actor into the database.
        /// </summary>
        /// <param name="actorsInsertDTO">Object to insert.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     POST /api/Movies/InsertActor
        ///     {
        ///         "fullName": "string"
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Successful operation.</response>
        /// <response code="400">Client error.</response>
        [HttpPost("InsertActor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult InsertActor(ActorsInsertDTO actorsInsertDTO)
        {
            try
            {
                _moviesInfrastructure.InsertActor(actorsInsertDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("error");
            }
        }
        #endregion

        #region PUT
        /// <summary>
        /// Update a movie into the data base.
        /// </summary>
        /// <param name="moviesUpdateDTO">Object movie to insert.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     PUT /api/Movies/UpdateMovie
        ///     {
        ///         "movieId": int,
        ///         "titleMovie": "string",
        ///         "descriptionMovie": "string",
        ///         "releaseMovie": "datatime",
        ///         "runningTimeMovie": int,
        ///         "genreId": int,
        ///         "awardId": int
        ///     }
        /// </remarks>
        /// <response code="200">Successful operation.</response>
        /// <response code="400">Si hubo un error al insertar la película.</response>
        [HttpPut("UpdateMovie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateMovie(MoviesUpdateDTO moviesUpdateDTO)
        {
            try
            {
                _moviesInfrastructure.UpdateMovie(moviesUpdateDTO);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }
        #endregion

        #region DELETE
        /// <summary>
        /// Delete a movie by its ID.
        /// </summary>
        /// <param name="movieId">ID of the movie to be deleted.</param>
        /// <returns>Answer.</returns>
        /// <remarks>
        /// Request:
        ///
        ///     DELETE /api/Movies/DeleteMovie
        ///     {
        ///         "movieId": int
        ///     }
        /// </remarks>
        /// <response code="200">Successful operation.</response>
        /// <response code="400">Client error.</response>
        [HttpDelete("DeleteMovie")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMovie(int movieId)
        {
            try
            {
                _moviesInfrastructure.DeleteMovie(movieId);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }
        #endregion
    }
}
