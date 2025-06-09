using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expanses;
public class RegisterExpanseUseCase
{
    public RegisterExpanseResponse Handle(RegisterExpanseRequest request)
    {

        Validate(request);

        return new RegisterExpanseResponse
        {
            Title = request.Title
        };
    }


    private void Validate(RegisterExpanseRequest request)
    {
        var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);

        if (titleIsEmpty)
        {
            throw new ArgumentException("The title is required.");
        }

        if (request.Amount <= 0)
        {
            throw new ArgumentException("The amount must be grather than zero.");
        }

        var result = DateTime.Compare(request.Date, DateTime.UtcNow);

        if (result > 0)
        {
            throw new ArgumentException("Expanses cannot be for future");
        }

        var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.Type);

        if (!paymentTypeIsValid)
        {
            throw new ArgumentException("Payment type is not valid.");
        }

    }
}
