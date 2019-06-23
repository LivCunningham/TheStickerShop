using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TheStickerShopApi.Models;
using thestickershop;


namespace TheStickerShopApi.Controllers

{
  [ApiController]
  [Route("api/[controller]")]
  public class ItemsController : ControllerBase
  {
    private DatabaseContext db;

    public ItemsController() => this.db = new DatabaseContext();

    [HttpPost]
    public ActionResult<StickerShopItems> Post([FromBody]StickerShopItems stickers)
    {
      //
      var db = new DatabaseContext();
      db.StickerShopItems.Add(stickers);
      db.SaveChanges();
      return stickers;

    }

  }
}