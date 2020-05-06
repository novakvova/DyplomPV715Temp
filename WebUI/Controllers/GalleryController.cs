using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class GalleryItemModel {
        public  int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }

    }


    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GalleryController : ControllerBase
    {
        public IActionResult Index()
        {
            List<GalleryItemModel> list = new List<GalleryItemModel>
            {

                new   GalleryItemModel  {
                Id=1,
                Url= "https://avatars.mds.yandex.net/get-zen_doc/1657335/pub_5d90d04d8f011100ad16812d_5d90ddefdf944400ad95f764/scale_1200",
                Title= "Oksana"
            },
              new GalleryItemModel {
                Id=2,
                Url="https://www.biletik.aero/upload/resize_cache/medialibrary/227/compressed/22743d951e0d5711a029e686c7db39e7.jpg",
                Title= "Yana+Lena"
            },
                new   GalleryItemModel  {
                Id=3,
                Url= "https://avatars.mds.yandex.net/get-zen_doc/1657335/pub_5d90d04d8f011100ad16812d_5d90ddefdf944400ad95f764/scale_1200",
                Title= "sfsf"
                }
};
            //Thread.Sleep(2000);
            return Ok(list);
        }


  
    }
}
