using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Model.Requests;
using AccountManagement.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseCRUDController<Model.User, object, UserUpsertRequerst, UserUpsertRequerst>
    {
        public UserController(ICRUDService<Model.User, object, UserUpsertRequerst, UserUpsertRequerst> service) : base(service)
        {
        }
    }

}