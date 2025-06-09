namespace Sistema.Models;

public class Estacionamento
{
  public int PrecoInicial { get; set; }
  public int PrecoPorHora { get; set; }
  public List<Cliente>? Clientes { get; set; }

  public Estacionamento()
  {
    Clientes = new List<Cliente>();
  }

  public void AdicionarCliente(Cliente cliente)
  {
    Clientes.Add(cliente);
  }

  public void RemoverCliente(string nome)
  {
    Clientes.RemoveAll(c => c.Nome == nome);
  }

  public void ListarClientes()
  {
    foreach (var i in Clientes)
    {
      int valor = PrecoInicial + PrecoPorHora * i.TempoEstacionado;
      Console.WriteLine($"cliente: {i.Nome} | placa: {i.Placa} | valor: {valor}");
    }
  }
}
