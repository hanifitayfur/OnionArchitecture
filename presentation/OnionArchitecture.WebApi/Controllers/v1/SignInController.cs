using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Commands.SignIn;

namespace OnionArchitecture.WebApi.Controllers.v1
{
    public class SignInController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> SignInMobilePhoneNumber(SignInMobilePhoneNumberCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}