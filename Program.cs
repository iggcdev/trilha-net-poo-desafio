using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"123456789", modelo:"Modelo 1", imei:"9876543210",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"987654321",modelo:"Modelo 2", imei:"0123456789", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");