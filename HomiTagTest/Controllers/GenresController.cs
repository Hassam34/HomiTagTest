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
    public class GenresController : ApiController
    {
        Entities db = new Entities();

        //Get all Generes
        public JsonResult Get()
        {
            try
            {
                var generes = db.Generes.ToList();
                return new JsonResult
                {
                    Data = new
                    {
                        status = true,
                        generes
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
        //Get Generes by Id
        public JsonResult Get(int Id)
        {
            try
            {
                var generes = db.Generes.Find(Id);
                if (generes != null)
                {
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            generes
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
                            Meesage = "No Genres Found"
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
        //Add Genere 
        public JsonResult Post([FromBody] Genere addGenere)
        {
            try
            {
                var Gener = new Genere();
                Gener.Name = addGenere.Name;
                Gener.Statsus = true;
                Gener.AddedBy = addGenere.AddedBy;
                Gener.CreationTimeStamp = DateTime.Now;
                db.Generes.Add(Gener);
                db.SaveChanges();
                return new JsonResult
                {
                    Data = new
                    {
                        status = true,
                        Meesage = "Genres is Added"
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
        //Delete Genere
        public JsonResult Delete(int Id)
        {
            try
            {
                var gene = db.Generes.Find(Id);

                if (gene != null)
                {
                    db.Generes.Remove(gene);
                    db.SaveChanges();
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            Meesage = "Genres is Deleted"
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
                            Message = "No Genres Found"
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
        //Edit Genere

        public JsonResult Put(int Id, [FromBody] Genere Updategenere)
        {
            try
            {
                var Genere = db.Generes.Find(Id);
                if (Genere != null)
                {
                    Genere.Name = Updategenere.Name;
                    db.SaveChanges();
                    return new JsonResult
                    {
                        Data = new
                        {
                            status = true,
                            Meesage = "Genres is Updated"
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
                            Message = "No Genres Found"
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
