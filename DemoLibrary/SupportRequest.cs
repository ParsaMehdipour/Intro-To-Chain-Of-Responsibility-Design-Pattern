namespace DemoLibrary;

public class SupportRequest
{
    public string Description { get; set; }
    public RequestCategory Category { get; set; }

    public SupportRequest(string description, RequestCategory category)
    {
        Description = description;
        Category = category;
    }
}

// Support request class
public enum RequestCategory
{
    GeneralInquiry,
    TechnicalIssue,
    BillingProblem
}
