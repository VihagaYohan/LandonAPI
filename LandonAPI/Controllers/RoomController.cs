using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonAPI.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	[ApiVersion("1.0")]
	public class RoomController:ControllerBase
	{
		[HttpGet(Name = nameof(GetRooms))]
		public IActionResult GetRooms() 
		{
			throw new NotImplementedException();
		}
	}
}
