using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo005_Mangas_ApiRest.Controllers
{

    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AutorController : ApiController
    {
        mangaEntities context;

        public AutorController()
        {
            context = new mangaEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Autor
        public List<TBL_AUTOR> Get()
        {
            return context.TBL_AUTOR.ToList();
        }

        // GET: api/Autor/5
        public TBL_AUTOR Get(int id)
        {
            return context.TBL_AUTOR.Where(man => man.id_autor == id).SingleOrDefault();
        }

        // POST: api/Autor
        public int Post(TBL_AUTOR nuevoAutor)
        {
            context.TBL_AUTOR.Add(nuevoAutor);
            context.SaveChanges();
            return nuevoAutor.id_autor;
        }

        // PUT: api/Autor/5
        public bool Put(int id, TBL_AUTOR autor)
        {
            TBL_AUTOR autorTemp = Get(id);
            if (autorTemp != null)
            {
                autorTemp.id_autor = autor.id_autor;
                autorTemp.nombre_autor = autor.nombre_autor;
                autorTemp.fecha_nacimiento_autor= autor.fecha_nacimiento_autor;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Autor/5
        public bool Delete(int id)
        {
            TBL_AUTOR autorTemp = Get(id);
            if (autorTemp != null)
            {
                context.TBL_AUTOR.Remove(autorTemp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
