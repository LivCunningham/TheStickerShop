using System;

namespace TheStickerShopApi.Models
{
  public class StickerShop
  {
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Boolean In_Stock { get; set; }
    public int Price { get; set; }
    public DateTime DateOrdered { get; set; }
  }
}