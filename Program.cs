// See https://aka.ms/new-console-template for more information
using FebSec4Prj;

Console.WriteLine("WELCOME TO JOE'S PIZZA SHOAP!");
Console.WriteLine("Enter the Shoapname:Slice Deligh");
Console.WriteLine("Enter the Address:Hyd");
Pizza p=new Pizza();
Console.WriteLine(p.Authenticate("Slice Delight", "Hyd"));