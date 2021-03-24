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
    public class DocumentController : ControllerBase
    {
        //DocumentDBContext documentDBContext;
        //public DocumentController(DocumentDBContext _documentDBContext)
        //{
        //    this.documentDBContext = _documentDBContext;
        //}

        public IEnumerable<Document> Get()
        {
            try
            {
                using (DocumentDBContext documentDBContext = new DocumentDBContext())
                {
                    return documentDBContext.Documents.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            
        }
        
        [HttpPost]
        public IActionResult Post(Document doc)
        {
            try
            {
                using (DocumentDBContext documentDBContext = new DocumentDBContext())
                {
                    documentDBContext.Add(doc);
                    documentDBContext.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
