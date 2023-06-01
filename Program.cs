using estoque;

Sorvete kibon = new Sorvete(30,20);

//Aqui, alteramos a data de checagem do estoque de sorvetes da "Kibon"
kibon.AlterarDiaChecagem(12);

//O método "VendaSorvete" aponta para quando um sorvete é vendido. Ou seja, o valor em estoque diminui.
kibon.VendaSorvete(0);

//Já o método "ReposicaoSorvete" é usado para repor a quantidade em estoque.
kibon.ReposicaoSorvete(100);

//Por fim, o método "PerdaSorvete" é usado quando algum sorvete estraga ou é retirado de estoque por algum motivo específico.
kibon.PerdaSorvete(0);



Console.WriteLine("O dia de checagem do estoque de sorvetes da Kibon é: " + kibon.DiaChecagem);
Console.WriteLine("Hoje, há " + kibon.QuantSorvete + " sorvetes da Kibon em estoque");
