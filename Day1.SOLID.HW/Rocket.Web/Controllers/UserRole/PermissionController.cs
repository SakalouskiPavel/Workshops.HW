using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using Rocket.BL.Common.Models.User;
using Rocket.BL.Common.Models.UserRoles;
using Rocket.BL.Services.UserServices;
using Swashbuckle.Swagger.Annotations;

namespace Rocket.Web.Controllers.UserRole
{
    [RoutePrefix("permission")]
    public class PermissionController : ApiController
    {
        private readonly PermissionService _permissionService;

        public PermissionController(PermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        
        [HttpGet]
        [Route("{id:int:min(1)}")]
        [SwaggerResponse(HttpStatusCode.OK, Description = "Returns Permission.", Type = typeof(Permission))]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult GetPermissionById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            var model = _permissionService.GetPermissionByUser(id);

            return model == null ? (IHttpActionResult)NotFound() : Ok(model);
        }

        [HttpGet]
        [Route("GetPermissionByRole{id:int:min(1)}")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult GetPermissionByRole(string user)
        {
            var model = _permissionService.GetPermissionByUser(user);
            return model == null ? (IHttpActionResult)NotFound() : Ok(model);
        }

        [HttpGet]
        [Route("all")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult GetAllPermissions()
        {
            //_permissionService.Get(null, null, "Permission");
            var model = _permissionService.GetAllPermissions();
            return model == null ? (IHttpActionResult)NotFound() : Ok(model);
        }

        [HttpPost]
        [SwaggerResponse(HttpStatusCode.Created)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult InsertPermission(Permission permission, string user)
        {
            if (permission == null)
            {
                return BadRequest("Model cannot be empty");
            }

            _permissionService.InsertPermission(permission, user);
            return Created($"permission/{permission.Id}", permission);
        }
       
        [HttpDelete]
        [Route("{id:int:min(1)}")]
        [SwaggerResponse(HttpStatusCode.Accepted)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        [SwaggerResponse(HttpStatusCode.BadRequest)]
        [SwaggerResponse(HttpStatusCode.InternalServerError)]
        public IHttpActionResult DeletePermissionById(Permission permission, string user)
        {
            
            if (ReferenceEquals(permission, null) || string.IsNullOrEmpty(user))
            {
                return BadRequest("Resources.BadRequestMessage");
            }
            

            _permissionService.Delete(permission, user);
            return new StatusCodeResult(HttpStatusCode.Accepted, Request);
        }
    }
}