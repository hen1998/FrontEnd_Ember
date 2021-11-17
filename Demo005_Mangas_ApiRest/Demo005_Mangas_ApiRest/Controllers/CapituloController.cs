using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo005_Mangas_ApiRest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CapituloController : ApiController
    {
        mangaEntities context;

        public CapituloController()
        {
            context = new mangaEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Capitulo
        public List<TBL_CAPITULO> Get()
        {
            return context.TBL_CAPITULO.ToList();
        }

        // GET: api/Capitulo/5
        public TBL_CAPITULO Get(int id)
        {
            return context.TBL_CAPITULO.Where(man => man.id_capitulo== id).SingleOrDefault();
        }

        // POST: api/Capitulo
        public int Post(TBL_CAPITULO nuevoCapitulo)
        {
            context.TBL_CAPITULO.Add(nuevoCapitulo);
            context.SaveChanges();
            return nuevoCapitulo.id_capitulo;
        }

        // PUT: api/Capitulo/5
        public bool Put(int id, TBL_CAPITULO capitulo)
        {
            TBL_CAPITULO capituloTemp = Get(id);
            if (capituloTemp != null)
            {
                capituloTemp.id_manga= capitulo.id_manga;
                capituloTemp.titulo_capitulo= capitulo.titulo_capitulo;
                capituloTemp.numero_capitulo= capitulo.numero_capitulo;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Capitulo/5
        public bool Delete(int id)
        {
            TBL_CAPITULO capituloTemp = Get(id);
            if (capituloTemp != null)
            {
                context.TBL_CAPITULO.Remove(capituloTemp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}