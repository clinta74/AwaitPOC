using AwaitPOC;

var businessLayer = new BusinessLayer();

Console.WriteLine("Starting program...");

var bl1 = businessLayer.DoIt1();
var bl2 = businessLayer.DoIt2();

Console.WriteLine("Business layers started.");

Console.WriteLine("Bl1 start.");
var result1 = await bl1;
Console.WriteLine($"Bl1 done. {result1}");

Console.WriteLine("Bl2 start.");
var result2 = await bl2;
Console.WriteLine($"Bl2 done. {result2}");

Console.WriteLine("Starting When All.");

var results = await Task.WhenAll([businessLayer.DoIt1(), businessLayer.DoIt2()]);
Console.WriteLine($"When all done. {string.Join(", ", results)}");

Console.WriteLine("Stoping program...");