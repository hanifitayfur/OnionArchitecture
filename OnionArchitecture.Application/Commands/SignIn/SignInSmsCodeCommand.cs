using System.ComponentModel.DataAnnotations;
using MediatR;
using OnionArchitecture.Application.Response;

namespace OnionArchitecture.Application.Commands.SignIn
{
    public class SignInSmsCodeCommand : IRequest<ServiceResponse<SignInUserCommandResult>>
    {
        [Required] public string MobilePhoneNumber { get; set; }

        [Required(ErrorMessage = "Lütfen telefonuza gelen sms kodunu giriniz")]
        public string Code { get; set; } = "05446963445";
    }
}