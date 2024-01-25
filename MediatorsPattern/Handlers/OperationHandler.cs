using MediatorsPattern.Models;
using MediatR;
using static MediatorsPattern.Models.OperationModel;

namespace MediatorsPattern.Handlers
{
    public class OperationHandler : IRequestHandler<RequestModel, ResponseModel>
    {
        public async Task<ResponseModel> Handle(RequestModel request, CancellationToken cancellationToken)
        {
            await Task.Delay(0, cancellationToken);
            return new ResponseModel()
            {
                Total = request.TypeOperation switch
                {
                    TypeOperation.resta => request.NumUno - request.NumDos,
                    TypeOperation.multiplica => request.NumUno * request.NumDos,
                    TypeOperation.division => request.NumUno / request.NumDos,
                    _ => request.NumUno + request.NumDos,
                },
            };
        }
    }
}
