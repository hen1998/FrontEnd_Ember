using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo005_Mangas_ApiRest.Controllers
{
    [EnableCors(origins: "*", headers:"*",methods:"*")]
    public class EditorialController : ApiController
    {
        mangaEntities context;

        public EditorialController()
        {
            context = new mangaEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Editorial
        public List<TBL_EDITORIAL> Get()
        {
            return context.TBL_EDITORIAL.ToList();
        }

        // GET: api/Editorial/5
        public TBL_EDITORIAL Get(int id)
        {
            return context.TBL_EDITORIAL.Where(man => man.id_editorial == id).SingleOrDefault();
        }

        // POST: api/Editorial
        public int Post(TBL_EDITORIAL nuevoEditorial)
        {
            context.TBL_EDITORIAL.Add(nuevoEditorial);
            context.SaveChanges();
            return nuevoEditorial.id_editorial;
        }

        // PUT: api/Editorial/5
        public bool Put(int id, TBL_EDITORIAL editorial)
        {
            TBL_EDITORIAL editorialTemp = Get(id);
            if (editorialTemp != null)
            {
                editorialTemp.nombre_editorial = editorial.nombre_editorial;
                editorialTemp.fundacion_editorial= editorial.fundacion_editorial;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Editorial/5
        public bool Delete(int id)
        {
            TBL_EDITORIAL editorialTemp = Get(id);
            if (editorialTemp != null)
            {
                context.TBL_EDITORIAL.Remove(editorialTemp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
