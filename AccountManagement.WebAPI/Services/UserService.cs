using AccountManagement.Model.Requests;
using AccountManagement.WebAPI.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountManagement.WebAPI.Services
{
    public class UserService : BaseCRUDService<Model.User, object, Database.User, UserUpsertRequerst, UserUpsertRequerst>
    {
        public UserService(AccountManagementContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.User> Get(object search)
        {
            var users = _context.Users.Where(x => x.Active == true).ToList();

            return _mapper.Map<List<Model.User>>(users);
        }

        public override Model.User Insert(UserUpsertRequerst request)
        {
            var entity = _mapper.Map<Database.User>(request);

            entity.Password = "AccountManagement!*";

            entity.Password = Helpers.PasswordGenerator.GenerateHash(entity.Password);

            _context.Users.Add(entity);
            _context.SaveChanges();


            return _mapper.Map<Model.User>(entity);

        }

        public override Model.User Update(int id, UserUpsertRequerst request)
        {
            var entity = _context.Users.Find(id);

            request.Password = entity.Password;
            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public override Model.User Delete(int id)
        {
            var entity = _context.Users.Find(id);

            entity.Active = false;

            _context.Users.Attach(entity);
            _context.Users.Update(entity);

            _context.SaveChanges();


            return _mapper.Map<Model.User>(entity);
        }
    }

}