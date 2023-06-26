using legoas_test.UseCases.RoleItemCases.RoleItemCreate;
using legoas_test.UseCases.RoleItemCases.RoleItemDelete;
using legoas_test.UseCases.RoleItemCases.RoleItemGet;
using legoas_test.UseCases.RoleItemCases.RoleItemGetAll;
using legoas_test.UseCases.RoleItemCases.RoleItemUpdate;
using Microsoft.AspNetCore.Mvc;

namespace legoas_test.Controllers
{
	public class RoleItemController : ApiControllerBase
	{
		#region Create
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<RoleItemCreateResponse>> PostAsync([FromBody] RoleItemCreateRequest createRoleItem)
		{
			var response = await Mediator.Send(createRoleItem);
			return Ok(response);
		}
		#endregion

		#region Update
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<RoleItemUpdateResponse>> PutAsync([FromBody] RoleItemUpdateRequest updateRoleItem)
		{
			var response = await Mediator.Send(updateRoleItem);
			return Ok(response);
		}
		#endregion

		#region Delete
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<RoleItemDeleteResponse>> DeleteAsync([FromBody] RoleItemDeleteRequest deleteRoleItem)
		{
			var response = await Mediator.Send(deleteRoleItem);
			return Ok(response);
		}
		#endregion

		#region Get
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<RoleItemGetResponse>> GetAsync()
		{
			var response = await Mediator.Send(new RoleItemGetRequest());
			return Ok(response);
		}
		#endregion

		#region GetAll
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<RoleItemGetAllResponse>> GetAllAsync()
		{
			var response = await Mediator.Send(new RoleItemGetAllRequest());
			return Ok(response);
		}
		#endregion
	}
}
