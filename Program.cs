using DesafioPOO.Models;

Nokia nokia = new Nokia("79999262212","S20","3868473597",6);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash of clans");
nokia.InstalarAplicativo("PUBG");
nokia.InstalarAplicativo("Fortnite");

Iphone iphone = new Iphone("79998590671","15","2938573621",4);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");


// TODO: Realizar os testes com as classes Nokia e Iphone