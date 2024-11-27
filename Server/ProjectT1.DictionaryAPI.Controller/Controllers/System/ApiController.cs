// ***********************************************************************
// Assembly         : ProjectX1.DictionaryAPI.Controller
// Author           : Admin
// Created          : 09-09-2023
//
// Last Modified By : Admin
// Last Modified On : 09-09-2023
// ***********************************************************************
// <copyright file="ApiController.cs" company="ProjectX1.DictionaryAPI.Controller">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using GenerateModelSQLServerEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]
namespace ProjectT1.DictionaryAPI.Controller.Controllers {
    /// <summary>
    /// Class ApiController.
    /// Implements the <see cref="ControllerBase" />
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}")]
    public class ApiController : ControllerBase {
        /// <summary>
        /// The context
        /// </summary>
        private readonly DatabaseContext _context;
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<ApiController> _logger;
        //DM0002Service cm;
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="logger">The logger.</param>
        public ApiController(DatabaseContext context, ILogger<ApiController> logger) {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Ons this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("on")]
        public ActionResult on() {
            _logger.LogTrace("Running...");
            return Ok("Running...");
        }

        /// <summary>
        /// Databases the on.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("ondb")]
        public ActionResult dbOn() {
            //if (!Request.Headers.Keys.Contains("Authorization")) return Unauthorized();
            //if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out var authHeader)) return Unauthorized();

            var dbConnected = _context != null && _context.Database.GetDbConnection().ConnectionString != null;
            _logger.LogTrace($"Running... DB connected: {dbConnected}");
            return Ok($"Running... DB connected: {dbConnected}");
        }

        /// <summary>
        /// Ons the error.
        /// </summary>
        /// <returns>ActionResult.</returns>
        /// <exception cref="System.Exception">Error test</exception>
        [HttpGet]
        [Route("onerror")]
        public ActionResult onError() {
            throw new System.Exception("Error test");
        }

        /// <summary>
        /// Ons the content of the no.
        /// </summary>
        /// <returns>ActionResult.</returns>
        [HttpGet]
        [Route("onnocontent")]
        public ActionResult onNoContent() {
            return NoContent();
        }
    }
}
