using AccountManagement.Model.Requests;
using AccountManagement.WebAPI.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.WebAPI.Services
{
    public class MeetingService : BaseCRUDService<Model.Meeting, object, Database.Meeting, MeetingUpsertRequest, MeetingUpsertRequest>
    {
        public MeetingService(AccountManagementContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Meeting> Get(object search)
        {
            var query = _context.Meetings.Include(x => x.Client).Include(y => y.User).AsQueryable();

            var list = query.ToList();
            return _mapper.Map<List<Model.Meeting>>(list);
        }
    }
}


