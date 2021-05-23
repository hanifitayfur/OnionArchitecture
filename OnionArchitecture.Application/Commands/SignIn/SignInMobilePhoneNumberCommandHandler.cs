using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Application.Response;

namespace OnionArchitecture.Application.Commands.SignIn
{
    public class
        SignInMobilePhoneNumberCommandHandler : IRequestHandler<SignInMobilePhoneNumberCommand, ServiceResponse<bool>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public SignInMobilePhoneNumberCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public Task<ServiceResponse<bool>> Handle(SignInMobilePhoneNumberCommand request,
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}