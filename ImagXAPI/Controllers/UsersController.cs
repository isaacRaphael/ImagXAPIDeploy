﻿using AutoMapper;
using ImagXAPI.Contracts;
using ImagXAPI.DTOs.InComing;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public UsersController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<ActionResult<ICollection<UserResponseDto>>> GetAll()
        {
            var users =  await  _unitOfWork.Users.GetAll();
            if (users is null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<UserResponseDto>>(users));
               
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDto>> GetById(string id)
        {
            var user = await _unitOfWork.Users.GetById(id);
            if (user is null)
                return NotFound();
            return Ok(_mapper.Map<UserResponseDto>(user));
        }

        [HttpGet("ByEmail")]
        public async Task<ActionResult<UserResponseDto>> GetByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user is null)
                return NotFound(new { Success = false, Message = "User not found" });

            return Ok(_mapper.Map<UserResponseDto>(user));
        }

        [HttpGet("paginated")]
        public async Task<ActionResult<ICollection<UserResponseDto>>> GetPaginated([FromQuery]int page = 1, int pageSize = 10)
        {
            var collection = await  _unitOfWork.Users.GetPaginated(page, pageSize);
            if (collection is null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<UserResponseDto>>(collection));
        }

        [HttpGet("Buddies/{id}")]
        public async Task<ActionResult<ICollection<UserResponseDto>>> GetBuddies(string id)
        {
            var buddies = await _unitOfWork.Users.GetBuddies(id);
            if (buddies is null)
                return NotFound();

            return Ok(_mapper.Map<ICollection<UserResponseDto>>(buddies));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveUser(string id)
        {
            var check = await _unitOfWork.Users.Remove(id);
            if (!check)
                return NotFound(new { Success = false, Message = "No such User" });

            return Ok(new { Success = true, Message = "User deleted successfully" }); 
            
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> UpdateUser([FromBody] JsonPatchDocument entity, [FromRoute] string id)
        {
            var patch = await _unitOfWork.Users.Update(entity, id);
            if (!patch)
                return NotFound(new { Success = false, Message = "No such user" });

            return Ok(new { Success = true, Message = "Updated User" });

        } 
        
        
        [HttpPatch("UpdateConnection/{id}")]
        public async Task<ActionResult> UpdateUserConnection([FromBody] JsonPatchDocument entity, [FromRoute] string id)
        {

            var patch = await _unitOfWork.Users.Update(entity, id);
            if (!patch)
                return NotFound(new { Success = false, Message = "No such user" });

            return Ok(new { Success = true, Message = "Updated User" });

        }

     

    }
}
