using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonAPI.Controllers
{
	[Route("/")]
	[ApiController]
	public class RootController:ControllerBase
	{
		[HttpGet(Name =nameof(GetRoot))]
		public IActionResult GetRoot() 
		{
			var response = new
			{

				href =Url.Link(nameof(GetRoot),null),
				rooms= new 
				{
					href = Url.Link(nameof(RoomController.GetRooms),null)
				}
			};
			return Ok(response);
		}
	}
}
