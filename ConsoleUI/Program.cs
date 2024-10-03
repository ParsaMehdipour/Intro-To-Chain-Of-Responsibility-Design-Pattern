// Set up the chain
using DemoLibrary;
using DemoLibrary.ConcreteHandlers;

var generalInquiries = new GeneralInquiriesHandler();
var technicalSupport = new TechnicalSupportHandler();
var billingSpecialist = new BillingSpecialistHandler();

generalInquiries.SetNext(technicalSupport).SetNext(billingSpecialist);

// Create some support requests
var request1 = new SupportRequest("How do I change my account password?", RequestCategory.GeneralInquiry);
var request2 = new SupportRequest("My application is crashing on startup", RequestCategory.TechnicalIssue);
var request3 = new SupportRequest("I was charged twice for my subscription", RequestCategory.BillingProblem);

// Process the requests
generalInquiries.HandleRequest(request1);
generalInquiries.HandleRequest(request2);
generalInquiries.HandleRequest(request3);