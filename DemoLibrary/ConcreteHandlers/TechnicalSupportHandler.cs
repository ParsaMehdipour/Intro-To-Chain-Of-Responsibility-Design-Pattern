using DemoLibrary.BaseHandlers;

namespace DemoLibrary.ConcreteHandlers;

/// <summary>
/// Concrete handlers for different levels of support
/// </summary>
public class TechnicalSupportHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Category == RequestCategory.TechnicalIssue)
        {
            Console.WriteLine($"Technical Support team handling request: {request.Description}");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}
