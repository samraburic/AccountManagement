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
    public class MeetingController : BaseCRUDController<Model.Meeting, object, MeetingUpsertRequest, MeetingUpsertRequest>
    {
        public MeetingController(ICRUDService<Model.Meeting, object, MeetingUpsertRequest, MeetingUpsertRequest> service) : base(service)
        {
        }
    }
}