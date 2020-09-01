using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Aplication.Interfaces;
using App.Core.Dto;

namespace WebApi.Controllers {

    public class IssueController : BaseController {

        private readonly IAppDbContext _context;

        public IssueController(IAppDbContext context){
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult> Test() {

            List<long> keys = new List<long>();

            List<User_DTO> db_enity = await _context.Users.AsNoTracking()
            .Include(e=>e.Role)
            .Select(e=> new User_DTO(){
                ID = e.ID,
                Role =  new Role_DTO {
                ID = e.Role.ID,
                Name = e.Role.Name,
            },
            }).ToListAsync();

            return Ok("Success");
        }
    }
}
