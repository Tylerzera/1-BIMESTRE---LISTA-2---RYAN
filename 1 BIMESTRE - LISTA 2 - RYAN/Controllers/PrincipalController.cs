﻿using _1_BIMESTRE___LISTA_2___RYAN.Configuration;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace _1_BIMESTRE___LISTA_2___RYAN.Controllers
{
    public class PrincipalController
    {
        public abstract class PrincipalAlunoController : ControllerBase
        {
            protected IActionResult ApiResponse<T>(T data, string message = null)
            {
                var response = new ApiResponse<T>
                {
                    Sucess = true,
                    Message = message,
                    Data = data
                };
                return Ok(response);
            }


            protected IActionResult ApiBadRequestResponse(ModelStateDictionary modelState, string message = "invalido")
            {

                return BadRequest(message);

            }
        }
    }
}
