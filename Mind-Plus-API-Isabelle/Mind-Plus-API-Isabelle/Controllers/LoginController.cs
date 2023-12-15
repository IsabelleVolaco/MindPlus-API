﻿using Microsoft.AspNetCore.Mvc;
using Mind_Plus_API_Isabelle.Contracts;
using Mind_Plus_API_Isabelle.Repository;

namespace Mind_Plus_API_Isabelle.Controllers
{
    [ApiController]
    [Route("colaboradores/login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpGet]
        public async Task<IActionResult> VerifyLogin(string email, string password)
        {
            return Ok(await _loginRepository.VerifyLogin(email, password));
        }
    }
}
