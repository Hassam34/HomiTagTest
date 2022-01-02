using HomiTagTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace HomiTagTest.Controllers
{

    public class MoviesController : ApiController
    {
        Entities db = new Entities();
        //Get all movies
        public JsonResult Get()
        {
            try
            {
                var movies = db.Movies.ToList();
                return new JsonResult
                {
                    Data = new
                    {
                        status = true,
                        movies
                    },
                };
            }
            catch (Exception e)
            {

                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Meesage = e.InnerException
                    },
                };
            }

        }
        //Get Movies by Id
        public JsonResult Get(int Id)
        {


            try
            {
                var movies = db.Movies.Find(Id);
                if (movies != null)
                {
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            movies
                        },
                    };
                }
                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Message = "Movie not found"
                    },
                };
            }
            catch (Exception e)
            {

                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Meesage = e.InnerException
                    },
                };
            }
        }
        //Add Movie 
        public JsonResult Post([FromBody] Movy addMovie)
        {
            try
            {
                var Movie = new Movy();
                Movie.Name = addMovie.Name;
                Movie.Description = addMovie.Description;
                Movie.GeneresId = addMovie.GeneresId;
                Movie.Rating = addMovie.Rating;
                Movie.Duration = addMovie.Duration;
                Movie.ReleaseDate = addMovie.ReleaseDate;
                Movie.Statsus = true;
                Movie.CreationTimeStamp = DateTime.Now;
                Movie.AddedBy = addMovie.AddedBy;
                db.Movies.Add(Movie);
                db.SaveChanges();
                return new JsonResult
                {
                    Data = new
                    {
                        status = true,
                        Meesage = "Movie is Added"
                    },
                };
            }
            catch (Exception e)
            {

                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Meesage = e.InnerException
                    },
                };
            }

        }
        //Delete Movie
        public JsonResult Delete(int Id)
        {
            try
            {
                var movie = db.Movies.Find(Id);
                if (movie != null)
                {
                    db.Movies.Remove(movie);
                    db.SaveChanges();
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            Meesage = "Movie is Deleted"
                        },
                    };
                }
                else
                {
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = false,
                            Message = "No Movie Found"
                        }
                    };
                }
            }
            catch (Exception e)
            {

                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Meesage = e.InnerException
                    },
                };
            }
          
        }
        //Edit Movie
        public JsonResult Put(int Id, [FromBody] Movy updateMovie)
        {
            try
            {
                var movie = db.Movies.Find(Id);
                if (movie != null)
                {
                    movie.Name = updateMovie.Name;
                    movie.GeneresId = updateMovie.GeneresId;
                    movie.Description = updateMovie.Description;
                    movie.Rating = updateMovie.Rating;
                    movie.ReleaseDate = updateMovie.ReleaseDate;
                    movie.Duration = updateMovie.Duration;
                    db.SaveChanges();
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            Meesage = "Movie is Updated"
                        },
                    };
                }
                else
                {
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = false,
                            Message = "No Movie Found"
                        },

                    };
                }
            }
            catch (Exception e)
            {

                return new JsonResult
                {
                    Data = new
                    {
                        status = false,
                        Meesage = e.InnerException
                    },
                };
            }
           
        }
    }
}
