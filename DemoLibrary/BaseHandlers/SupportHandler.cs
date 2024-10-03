using DemoLibrary.Interfaces;

namespace DemoLibrary.BaseHandlers;

/// <summary>
/// The default chaining behavior can be implemented inside a base handler class.
/// </summary>
public abstract class SupportHandler : ISupportHandler
{
    protected ISupportHandler nextHandler;

    public virtual void HandleRequest(SupportRequest request)
    {
        if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("Request cannot be handled.");
        }
    }

    public ISupportHandler SetNext(ISupportHandler handler)
    {
        nextHandler = handler;
        return handler;
    }
}
