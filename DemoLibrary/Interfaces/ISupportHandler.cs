namespace DemoLibrary.Interfaces;

/// <summary>
/// The Handler interface declares a method for building the chain of
/// handlers. It also declares a method for executing a request.
/// </summary>
public interface ISupportHandler
{
    void HandleRequest(SupportRequest request);
    ISupportHandler SetNext(ISupportHandler handler);
}
