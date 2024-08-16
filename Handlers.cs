using System;

public class AtenderClienteHandler : BaseHandler
{
    public override void HandleRequest(Pedido pedido)
    {
        Console.WriteLine("Garçom atendeu o cliente.");
        NextHandleRequest(pedido);
    }
}

public class ReceberPedidoHandler : BaseHandler
{
    public override void HandleRequest(Pedido pedido)
    {
        Console.WriteLine($"Garçom recebeu o pedido: {pedido.Descricao}.");
        NextHandleRequest(pedido);
    }
}

public class PrepararPedidoHandler : BaseHandler
{
    public override void HandleRequest(Pedido pedido)
    {
        Console.WriteLine($"Cozinha preparou o pedido: {pedido.Descricao}.");

        // Simulando quebra da corrente ⛓️
        //
        // if (BreakChain())
        // {
        //     Console.WriteLine($"Não foi possível preparar o pedido. Encerrando atendimento.");
        // }
        //
        // Fim

        NextHandleRequest(pedido);
    }
}

public class EntregarPedidoHandler : BaseHandler
{
    public override void HandleRequest(Pedido pedido)
    {
        Console.WriteLine($"Pedido entregue ao cliente: {pedido.Descricao}.");
        NextHandleRequest(pedido);
    }
}