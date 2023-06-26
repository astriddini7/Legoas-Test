using legoas_test.UseCases.ApplicationUserCases.ApplicationUserCreate;
using legoas_test.UseCases.ApplicationUserCases.ApplicationUserDelete;
using legoas_test.UseCases.ApplicationUserCases.ApplicationUserGet;
using legoas_test.UseCases.ApplicationUserCases.ApplicationUserGetAll;
using legoas_test.UseCases.ApplicationUserCases.ApplicationUserUpdate;
using Microsoft.AspNetCore.Mvc;

namespace legoas_test.Controllers
{
	public class ApplicationUserController : ApiControllerBase
	{
		#region Create
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationUserCreateResponse>> PostAsync([FromBody] ApplicationUserCreateRequest createApplicationUser)
		{
			var response = await Mediator.Send(createApplicationUser);
			return Ok(response);
		}
		#endregion

		#region Update
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationUserUpdateResponse>> PutAsync([FromBody] ApplicationUserUpdateRequest updateApplicationUser)
		{
			var response = await Mediator.Send(updateApplicationUser);
			return Ok(response);
		}
		#endregion

		#region Delete
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationUserDeleteResponse>> DeleteAsync([FromBody] ApplicationUserDeleteRequest deleteApplicationUser)
		{
			var response = await Mediator.Send(deleteApplicationUser);
			return Ok(response);
		}
		#endregion

		#region Get
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationUserGetResponse>> GetAsync()
		{
			var response = await Mediator.Send(new ApplicationUserGetRequest());
			return Ok(response);
		}
		#endregion

		#region GetAll
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationUserGetAllResponse>> GetAllAsync()
		{
			var response = await Mediator.Send(new ApplicationUserGetAllRequest());
			return Ok(response);
		}
		#endregion
	}
}
