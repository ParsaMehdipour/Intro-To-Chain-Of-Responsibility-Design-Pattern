using DemoLibrary.BaseHandlers;

namespace DemoLibrary.ConcreteHandlers;

/// <summary>
/// Concrete handlers for different levels of support
/// </summary>
public class GeneralInquiriesHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Category == RequestCategory.GeneralInquiry)
        {
            Console.WriteLine($"General Inquiries team handling request: {request.Description}");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}
