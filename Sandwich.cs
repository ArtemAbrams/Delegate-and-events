using System.Diagnostics;

namespace ConsoleApp
{

 class Butter
 {
  public int Weight { get; set; }
  public int Quality { get; set; }

  public Butter(int weight, int quality)
  {
   this.Quality = quality;
   this.Weight = weight;
  }
 }

 class Bread
 {
  public int Weight { get; set; }
  public int Quality { get; set; }

  public Bread(int weight, int quality)
  {
   this.Weight = weight;
   this.Quality = quality;
  }

  public static Sandwich operator +(Bread bread, Butter butter)
  {
   return new Sandwich((bread.Quality+butter.Quality)/2, butter.Weight+bread.Weight);
  }
 }

 class Sandwich
 {
  public int Quality;
  public int Weight;

  public Sandwich(int quality, int weight)
  {
   this.Quality = quality;
   this.Weight = weight;
  }
 }
}