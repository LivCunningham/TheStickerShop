using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StickerShop;
using TheStickerShopApi.Models;




namespace TheStickerShopApi.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class StickerItemsController : ControllerBase
  {

    private DatabaseContext db;

    public StickerItemsController()
    {
      this.db = new DatabaseContext();
    }
    [HttpGet]
    public ActionResult<List<Stickers>> Get()
    {


      var rv = db.Stickers;
      return rv.ToList();
    }

    [HttpGet("OutOfStock")]
    public ActionResult<List<Stickers>> OutOfStock()
    {


      var rv = db.StickerItems.Where(y => y.In_Stock < 1);
      // return rv.ToList();
    }

    [HttpPost]
    public ActionResult<Stickers> Post([FromBody]TheStickerShopApi stickers)
    {

      db.StickerItems.Add(stickers);
      db.SaveChanges();
      return stickers;
    }

    [HttpPut("{id}")]
    public ActionResult<Stickers> UpdateItem([FromRoute]int id, [FromBody]TheStickerShopApi item)
    {


      var stickers = db.stickersItems.FirstOrDefault(x => x.Id == id);
      stickers.SKU = item.SKU;
      stickers.Name = item.Name;
      stickers.Description = item.Description;
      stickers.NumberInStock = item.In_Stock;
      stickers.Price = item.Price;
      db.SaveChanges();
      return stickers;
    }

    [HttpGet("{id}")]
    public ActionResult<Stickers> GetById([FromRoute]int id)
    {
      var db = new DatabaseContext();

      var stickerID = db.stickersItems.FirstOrDefault(f => f.Id == id);
      if (stickerID == null)
      {
        return NotFound();
      }
      return stickersID;
    }

    [HttpGet("SKU/{SKU}")]
    public ActionResult<Stickers> GetBySKU([FromRoute]string SKU)
    {

      var stickers = db.stickersItems.FirstOrDefault(f => f.SKU == SKU);
      if (stickers == null)
      {
        return NotFound();
      }
      return stickers;
    }


    [HttpDelete("{id}")]
    public ActionResult DeleteItem(int id)
    {

      var item = db.stickersItems.FirstOrDefault(f => f.Id == id);
      if (item == null)
      {
        return NotFound();
      }
      else
      {
        db.stickersItems.Remove(item);
        db.SaveChanges();
        return Ok();
      }
    }

  }
}

