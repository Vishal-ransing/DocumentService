using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentService.Models;

namespace DocumentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //DocumentDBContext documentDBContext;
        //public UserController(DocumentDBContext _documentDBContext)
        //{
        //    this.documentDBContext = _documentDBContext;
        //}

        public IEnumerable<User> Get()
        {
            using (DocumentDBContext documentDBContext = new DocumentDBContext())
            {
                return documentDBContext.Users.ToList();
            }
        }

        
    }
}
