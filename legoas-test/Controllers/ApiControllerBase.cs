using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace legoas_test.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ApiControllerBase : ControllerBase
	{
		private ISender? _mediator;

		protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;
	}
}
