using System;

namespace TheStickerShopApi.Models
{
  public class StickerShopItems
  {
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Boolean InStock { get; set; } = true;
    public int Price { get; set; }
    public DateTime DateOrdered { get; set; } = DateTime.Now;
  }
}