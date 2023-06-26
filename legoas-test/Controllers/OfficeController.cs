using legoas_test.UseCases.OfficeCases.OfficeCreate;
using legoas_test.UseCases.OfficeCases.OfficeDelete;
using legoas_test.UseCases.OfficeCases.OfficeGet;
using legoas_test.UseCases.OfficeCases.OfficeGetAll;
using legoas_test.UseCases.OfficeCases.OfficeUpdate;
using Microsoft.AspNetCore.Mvc;

namespace legoas_test.Controllers
{
	public class OfficeController : ApiControllerBase
	{
		#region Create
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<OfficeCreateResponse>> PostAsync([FromBody] OfficeCreateRequest createOffice)
		{
			var response = await Mediator.Send(createOffice);
			return Ok(response);
		}
		#endregion

		#region Update
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<OfficeUpdateResponse>> PutAsync([FromBody] OfficeUpdateRequest updateOffice)
		{
			var response = await Mediator.Send(updateOffice);
			return Ok(response);
		}
		#endregion

		#region Delete
		[HttpDelete]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<OfficeDeleteResponse>> DeleteAsync([FromBody] OfficeDeleteRequest deleteOffice)
		{
			var response = await Mediator.Send(deleteOffice);
			return Ok(response);
		}
		#endregion

		#region Get
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<OfficeGetResponse>> GetAsync()
		{
			var response = await Mediator.Send(new OfficeGetRequest());
			return Ok(response);
		}
		#endregion

		#region GetAll
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<OfficeGetAllResponse>> GetAllAsync()
		{
			var response = await Mediator.Send(new OfficeGetAllRequest());
			return Ok(response);
		}
		#endregion
	}
}
