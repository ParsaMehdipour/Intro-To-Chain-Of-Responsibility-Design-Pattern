using DemoLibrary.BaseHandlers;

namespace DemoLibrary.ConcreteHandlers;

/// <summary>
/// Concrete handlers for different levels of support
/// </summary>
public class BillingSpecialistHandler : SupportHandler
{
    public override void HandleRequest(SupportRequest request)
    {
        if (request.Category == RequestCategory.BillingProblem)
        {
            Console.WriteLine($"Billing Specialist team handling request: {request.Description}");
        }
        else
        {
            base.HandleRequest(request);
        }
    }
}
