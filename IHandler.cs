public interface IHandler
{
    void HandleRequest(Pedido pedido);

    void SetNext(IHandler handler);

    bool BreakChain();
}

public abstract class BaseHandler : IHandler
{
    protected IHandler _next { get; set; }

    public abstract void HandleRequest(Pedido pedido);

    public void SetNext(IHandler handler)
    {
        _next = handler;
    }

    public void NextHandleRequest(Pedido pedido)
    {
        if (_next != null) _next.HandleRequest(pedido);
    }

    public bool BreakChain()
    {
        _next = null;
        return true;
    }
}