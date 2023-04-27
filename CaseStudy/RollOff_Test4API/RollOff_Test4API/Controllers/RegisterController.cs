﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RollOff_Test4API.Models.Domain;
using RollOff_Test4API.Models.DTO;
using RollOff_Test4API.Repository;
using System.Threading.Tasks;

namespace RollOff_Test4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IUser _user;
        private readonly IMapper mapper;

        public RegisterController(IUser user, IMapper mapper)
        {
          
            _user = user;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> AddLoginDetails(User loginTableDTO)
        {
            var employeeDTO = mapper.Map<Login>(loginTableDTO);
            await _user.AddLoginDetailsAsync(employeeDTO);
            if (employeeDTO != null)
            {
                return Ok("Success");

            }
            return Ok("Failure");
            //return Ok(employeeDTO);
        }
    }
}
