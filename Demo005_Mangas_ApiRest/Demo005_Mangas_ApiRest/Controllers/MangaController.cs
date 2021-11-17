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
    public class MangaController : ApiController
    {
        mangaEntities context;

        public MangaController()
        {
            context = new mangaEntities();
            context.Configuration.ProxyCreationEnabled = false;        
        }

        // GET: api/Manga
        public List<TBL_MANGA> GetMangas()
        {
            return context.TBL_MANGA.ToList();
        }

        // GET: api/Manga/5
        [HttpGet]
        public TBL_MANGA SeleccionarMangaPorId(int id)
        {
            return context.TBL_MANGA.Where(man => man.id_manga == id).SingleOrDefault();
        }

        // POST: api/Manga
        public int Post(TBL_MANGA nuevoManga)
        {
            context.TBL_MANGA.Add(nuevoManga);
            context.SaveChanges();
            return nuevoManga.id_manga;
        }

        // PUT: api/Manga/5
        public bool Put(int id, TBL_MANGA manga)
        {
            TBL_MANGA mangaTemp = SeleccionarMangaPorId(id);
            if (mangaTemp != null)
            {
                mangaTemp.id_autor = manga.id_autor;
                mangaTemp.id_editorial = manga.id_editorial;
                mangaTemp.nombre_espaniol_manga = manga.nombre_espaniol_manga;
                mangaTemp.logo_manga = manga.logo_manga;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Manga/5
        [HttpDelete]
        public bool EliminarManga(int id)
        {
            TBL_MANGA mangaTemp = SeleccionarMangaPorId(id);
            if (mangaTemp != null)
            {
                context.TBL_MANGA.Remove(mangaTemp);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
