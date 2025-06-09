using Sistema.Models;

Console.WriteLine("===== Iniciar =====");


Console.WriteLine("Qual será o valor inicial?");
int precoInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Qual será o valor pago por hora?");
int precoPorHora = int.Parse(Console.ReadLine());


Estacionamento e = new Estacionamento();
e.PrecoInicial = precoInicial;
e.PrecoPorHora = precoPorHora;

bool exibirMenu = true;

while (exibirMenu)
{
  Console.WriteLine("======================== MENU ==========================");

  Console.WriteLine("Digite 1 para adicionar um cliente");
  Console.WriteLine("Digite 2 para remover um cliente");
  Console.WriteLine("Digite 3 para Listar os clientes");
  Console.WriteLine("Digite 4 para Finalizar");

  switch (Console.ReadLine())
  {
    case "1":
      Cliente c = new Cliente();

      Console.WriteLine("Digite a placa do carro");
      c.Placa = Console.ReadLine();

      Console.WriteLine("Digite o nome do cliente");
      c.Nome = Console.ReadLine();

      Console.WriteLine("Quanto tempo passou estacionado?");
      c.TempoEstacionado = int.Parse(Console.ReadLine());

      e.AdicionarCliente(c);

      break;


    case "2":
      Console.WriteLine("Digite o nome do cliente a ser excluído");
      e.RemoverCliente(Console.ReadLine());
      break;
    case "3": e.ListarClientes(); break;
    case "4": exibirMenu = false; break;
  }
}

