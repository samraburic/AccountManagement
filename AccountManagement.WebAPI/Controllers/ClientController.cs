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
    public class ClientController : BaseCRUDController<Model.Client, object, ClientUpsertRequest, ClientUpsertRequest>
    {
        public ClientController(ICRUDService<Model.Client, object, ClientUpsertRequest, ClientUpsertRequest> service) : base(service)
        {
        }
    }
}