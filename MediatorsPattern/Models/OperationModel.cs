using MediatR;
using static MediatorsPattern.Models.OperationModel;

namespace MediatorsPattern.Models
{
    public class OperationModel
    {
        public enum TypeOperation
        {
            suma,
            resta,
            multiplica,
            division,
        }
    }

    public class RequestModel : IRequest<ResponseModel>
    {
        public decimal NumUno { get; set; }
        public decimal NumDos { get; set; }
        public TypeOperation TypeOperation { get; set; }
    }

    public class ResponseModel
    {
        public decimal Total { get; set; }
    }
}
