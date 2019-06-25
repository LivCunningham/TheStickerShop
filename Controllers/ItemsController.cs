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

    private DatabaseContext db;

    public ItemsController()
    {
      this.db = new DatabaseContext();
    }

    [HttpGet]
    public ActionResult<List<StickerShopItems>> Get()
    {
      //GET all of our sticker items in my inventory
      var rv = db.StickerItems;
      return rv.ToList();
    }


    [HttpPost]
    public ActionResult<StickerShopItems> Post([FromBody]StickerShopItems stickers)
    {
      //Create new inventory items 
      db.StickerItems.Add(stickers);
      db.SaveChanges();
      return stickers;

    }

    [HttpGet("{id}")]
    public ActionResult<StickerShopItems> GetOne([FromRoute]int id)
    {
      var sticker = db.StickerItems.FirstOrDefault(x => x.Id == id);
      if (sticker == null)
      {
        return NotFound();
      }
      return sticker;
    }

    // [HttpGet("OutOfStock")]
    // public ActionResult<List<StickerShopItems>> OutOfStock()
    // {
    //   //Out of Stock Items 
    //   var rv = db.StickerItems.Where(y => y.InStock == false);
    //   return rv.ToList();
    // }

    [HttpPut("{id}")]
    public ActionResult<StickerShopItems> UpdateItem([FromRoute]int id, [FromBody]StickerShopItems item)
    {

      //Update each Sticker item in my Inventory
      var stickerData = db.StickerItems.FirstOrDefault(f => f.Id == id);
      stickerData.SKU = item.SKU;
      stickerData.Name = item.Name;
      stickerData.Description = item.Description;
      stickerData.Price = item.Price;
      stickerData.DateOrdered = item.DateOrdered;
      db.SaveChanges();
      return stickerData;

    }

    // [HttpPut("{id}")]

    // public ActionResult<


  }
}