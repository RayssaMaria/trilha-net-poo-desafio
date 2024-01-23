using DesafioPOO.Models;


Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("8080-8080", "Iphone 13", "2222222", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("8008-8008", "C2", "2222542", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
