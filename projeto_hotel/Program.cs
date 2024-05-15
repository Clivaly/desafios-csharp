using projeto_hotel.models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Alan", sobrenome: "Neves");
Pessoa pessoa2 = new Pessoa(nome: "Tiago", sobrenome: "Silva");
Pessoa pessoa3 = new Pessoa(nome: "Enzo");
Pessoa pessoa4 = new Pessoa(nome: "Zezo");
Pessoa pessoa5 = new Pessoa(nome: "Athila", sobrenome: "Zendesk");
Pessoa pessoa6 = new Pessoa(nome: "George", sobrenome: "Cruz");
Pessoa pessoa7 = new Pessoa(nome: "Fatima", sobrenome: "Bernadez");
Pessoa pessoa8 = new Pessoa(nome: "Matias", sobrenome: "Speuber");
Pessoa pessoa9 = new Pessoa(nome: "Potter", sobrenome: "Harry");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);
hospedes.Add(pessoa3);
hospedes.Add(pessoa4);
hospedes.Add(pessoa5);
hospedes.Add(pessoa6);
hospedes.Add(pessoa7);
hospedes.Add(pessoa8);
hospedes.Add(pessoa9);

Suite suite = new Suite(tipoSuite: "Diamante", capacidade: 10, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach (var nome in hospedes)
{
    Console.WriteLine($"Hóspede: {nome}");
}

Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria().ToString("C")}");