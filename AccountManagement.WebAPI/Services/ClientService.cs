using AccountManagement.Model.Requests;
using AccountManagement.WebAPI.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.WebAPI.Services
{
    public class ClientService : BaseCRUDService<Model.Client, object, Database.Client, ClientUpsertRequest, ClientUpsertRequest>
    {
        public ClientService(AccountManagementContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override Model.Client Delete(int id)
        {
            var entity = _context.Clients.Find(id);

            var list = _context.Meetings.Where(x => x.ClientId == id).ToList();
            foreach (var item in list)
            {
                _context.Meetings.Remove(item);
                _context.SaveChanges();
            }

            _context.Clients.Remove(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Client>(entity);
        }
    }
}

