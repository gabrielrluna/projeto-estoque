using heranca.ProdutosDerivada;
using polimorfismo.ClasseDerivada;
using estoque;
using funcionarios.ClasseDerivada;

//Parte voltada para os estudos sobre herança

Arroz novoArroz = new Arroz();
novoArroz.Id = 1;
novoArroz.Marca = "Camil";
novoArroz.Tipo = "Parbolizado";
novoArroz.Ativo();

Bolacha novoBolacha = new Bolacha();
novoBolacha.Id = 1;
novoBolacha.Marca = "Camil";
novoBolacha.Tipo = "Parbolizado";
novoBolacha.Sabor = "Parbolizado";
novoBolacha.Ativo();

Sabonete novoSabonete = new Sabonete();
novoSabonete.Id = 1;
novoSabonete.Marca = "Camil";
novoSabonete.Aroma = "Parbolizado";
novoSabonete.Ativo();


//Parte voltada para os estudos sobre polimorfismo

Farinha novaFarinha = new Farinha();
novaFarinha.ConferirValidade();
novaFarinha.Encomendar();
novaFarinha.Separar();

Macarrao novoMacarrao = new Macarrao();
novoMacarrao.ConferirValidade();
novoMacarrao.Encomendar();
novoMacarrao.Separar();

Shampoo novoShampoo = new Shampoo();
novoShampoo.ConferirValidade();
novoShampoo.Encomendar();
novoShampoo.Separar();
Console.WriteLine("=========================");

//Parte voltada para os estudos sobre abstração

Carlos carlos = new Carlos();
string nomeCarlos = carlos.Nome();
string funcaoCarlos = carlos.Funcao();
double salarioCarlos = carlos.Salario();
Console.WriteLine(nomeCarlos);
Console.WriteLine(funcaoCarlos);
Console.WriteLine("Salário: " + salarioCarlos);
carlos.Atividade();
Console.WriteLine("=========================");


Claudio claudio = new Claudio();
string nomeClaudio = claudio.Nome();
string funcaoClaudio = claudio.Funcao();
double salarioClaudio = claudio.Salario();
Console.WriteLine(nomeClaudio);
Console.WriteLine(funcaoClaudio);
Console.WriteLine("Salário: " + salarioClaudio);
claudio.Atividade();
Console.WriteLine("=========================");

Marta marta = new Marta();
string nomeMarta = marta.Nome();
string funcaoMarta = marta.Funcao();
double salarioMarta = marta.Salario();
Console.WriteLine(nomeMarta);
Console.WriteLine(funcaoMarta);
Console.WriteLine("Salário: " + salarioMarta);
marta.Atividade();
Console.WriteLine("=========================");

Mauricio mauricio = new Mauricio();
string nomeMauricio = mauricio.Nome();
string funcaoMauricio = mauricio.Funcao();
double salarioMauricio = mauricio.Salario();
Console.WriteLine(nomeMauricio);
Console.WriteLine(funcaoMauricio);
Console.WriteLine("Salário: " + salarioMauricio);
mauricio.Atividade();
Console.WriteLine("=========================");

Silvana silvana = new Silvana();
string nomeSilvana = silvana.Nome();
string funcaoSilvana = silvana.Funcao();
double salarioSilvana = silvana.Salario();
Console.WriteLine(nomeSilvana);
Console.WriteLine(funcaoSilvana);
Console.WriteLine("Salário: " + salarioSilvana);
silvana.Atividade();
Console.WriteLine("=========================");

//Parte voltada para os estudos sobre encapsulamento

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
