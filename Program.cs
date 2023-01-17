using trilha_net_poo_desafio.models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("55598135","Modelo 2", "222222",64);
nokia.Ligar();
nokia.InstalarAplicativo("Chrome");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("77652135", "7 Geracao", "3333333", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
