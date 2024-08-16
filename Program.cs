using System;

public class Pedido
{
    public String Descricao { get; set; }
}

class Program
{
    static void Main()
    {
        var pedido = new Pedido { Descricao = "Pizza Margherita" };

        var atenderCliente = new AtenderClienteHandler();
        var receberPedido = new ReceberPedidoHandler();
        var prepararPedido = new PrepararPedidoHandler();
        var entregarPedido = new EntregarPedidoHandler();

        atenderCliente.SetNext(receberPedido);
        receberPedido.SetNext(prepararPedido);
        prepararPedido.SetNext(entregarPedido);

        atenderCliente.HandleRequest(pedido);
    }
}
