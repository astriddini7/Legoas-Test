using legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleCreate;
using legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleDelete;
using legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleGet;
using legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleGetAll;
using legoas_test.UseCases.ApplicationRoleCases.ApplicationRoleUpdate;
using Microsoft.AspNetCore.Mvc;

namespace legoas_test.Controllers
{
	public class ApplicationRoleController : ApiControllerBase
	{
		#region Create
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationRoleCreateResponse>> PostAsync([FromBody] ApplicationRoleCreateRequest createApplicationRole)
		{
			var response = await Mediator.Send(createApplicationRole);
			return Ok(response);
		}
		#endregion

		#region Update
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationRoleUpdateResponse>> PutAsync([FromBody] ApplicationRoleUpdateRequest updateApplicationRole)
		{
			var response = await Mediator.Send(updateApplicationRole);
			return Ok(response);
		}
		#endregion

		#region Delete
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationRoleDeleteResponse>> DeleteAsync([FromBody] ApplicationRoleDeleteRequest deleteApplicationRole)
		{
			var response = await Mediator.Send(deleteApplicationRole);
			return Ok(response);
		}
		#endregion

		#region Get
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationRoleGetResponse>> GetAsync()
		{
			var response = await Mediator.Send(new ApplicationRoleGetRequest());
			return Ok(response);
		}
		#endregion

		#region GetAll
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<ApplicationRoleGetAllResponse>> GetAllAsync()
		{
			var response = await Mediator.Send(new ApplicationRoleGetAllRequest());
			return Ok(response);
		}
		#endregion
	}
}
