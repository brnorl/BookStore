using FluentValidation;
using Webapi.BookOperations.GetBookDetail;

namespace WebApi.BookOperations.GetBookDetail
{

    public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
    {
        public GetBookDetailQueryValidator()
        {
            RuleFor(query => query.BookId).GreaterThan(0);//id>0
        }
    }
}