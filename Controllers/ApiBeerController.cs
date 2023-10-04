using AuraSP.Models;
using AuraSP.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuraSP.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApiBeerController : ControllerBase
	{
		private readonly PubContext _context;

		public ApiBeerController(PubContext context)
		{
			_context = context;
		}
		public async Task<List<BBViewModel>> Get()
			=> await _context.Beers.Include(b=>b.Brand)
			.Select(b => new BBViewModel
			{
				Name = b.Name,
				Brand = b.Brand.Name
			}).ToListAsync();

	}
}
