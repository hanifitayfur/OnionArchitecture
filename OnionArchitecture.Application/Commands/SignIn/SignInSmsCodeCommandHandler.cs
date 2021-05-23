using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Application.Response;

namespace OnionArchitecture.Application.Commands.SignIn
{
    public class
        SignInSmsCodeCommandHandler : IRequestHandler<SignInSmsCodeCommand, ServiceResponse<SignInUserCommandResult>>
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IApplicationDbContext _applicationDbContext;

        public SignInSmsCodeCommandHandler(IConfiguration configuration, IMapper mapper,
            IApplicationDbContext applicationDbContext)
        {
            _mapper = mapper;
            _configuration = configuration;
            _applicationDbContext = applicationDbContext;
        }

        public Task<ServiceResponse<SignInUserCommandResult>> Handle(SignInSmsCodeCommand request,
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}