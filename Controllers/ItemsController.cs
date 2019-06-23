using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using thestickershop;
using TheStickerShopApi.Models;

namespace TheStickerShopApi.Controllers

{
  [ApiController]
  [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {


    [HttpPost]
    public ActionResult<StickerShopItems> Post([FromBody]StickerShopItems stickers)
    {
      //
      var db = new DatabaseContext();
      db.StickerItems.Add(stickers);
      db.SaveChanges();
      return stickers;

    }

  }
}