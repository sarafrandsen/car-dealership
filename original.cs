// //     public bool WorthBuying(int maxPrice)
//     {
//       return (_price < (maxPrice + 100));
//     }
// //
// public class Program
// {
//   public static void Main()
//   {
//     Car porsche = new Car();
//     porsche.SetMakeModel("2014 Porsche 911");
//     porsche.SetPrice(114991);
//     porsche.SetMiles(7864);
//
//     Car ford = new Car();
//     ford.SetMakeModel("2011 Ford F450");
//     ford.SetPrice(55995);
//     ford.SetMiles(14241);
//
//     Car lexus = new Car();
//     lexus.SetMakeModel("2013 Lexus RX 350");
//     lexus.SetPrice(44700);
//     lexus.SetMiles(20000);
//
//     Car mercedes = new Car();
//     mercedes.SetMakeModel("Mercedes Benz CLS550");
//     mercedes.SetPrice(39900);
//     mercedes.SetMiles(37979);
//
//     List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//
//     foreach(Car automobile in Cars)
//     {
//       Console.WriteLine(automobile.GetMakeModel());
//     }
//
//     Console.WriteLine("Enter maximum price: ");
//     string stringMaxPrice = Console.ReadLine();
//     int maxPrice = int.Parse(stringMaxPrice);
//
//     List<Car> CarsMatchingSearch = new List<Car>(0);
//
//     for(int i = 0; i < Cars.Count; i++)
//     {
//       if (Cars[i].WorthBuying(maxPrice))
//       {
//         CarsMatchingSearch.Add(Cars[i]);
//       }
//     }
//     if (CarsMatchingSearch.Count == 0)
//     {
//       Console.WriteLine("No cars match your search");
//     }
//
//
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.GetMakeModel());
//     }
//   }
// }
