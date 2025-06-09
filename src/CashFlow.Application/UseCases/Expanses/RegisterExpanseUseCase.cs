using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expanses;
public class RegisterExpanseUseCase
{
    public RegisterExpanseResponse Handle(RegisterExpanseRequest request)
    {
        return new RegisterExpanseResponse
        {
            Title = request.Title
        };
    }
}
