using POCCosmosDB.Models;
using POCCosmosDB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CosmosDBtest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly DataPOCService _DataPOCs;

        public BooksController(DataPOCService bookService)
        {
            _DataPOCs = bookService;
        }

        [HttpGet]
        public ActionResult<List<DataPOC>> Get() =>
            _DataPOCs.Get();

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public ActionResult<DataPOC> Get(string id)
        {
            var book = _DataPOCs.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<DataPOC> Create(DataPOC book)
        {
            _DataPOCs.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, DataPOC bookIn)
        {
            var book = _DataPOCs.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _DataPOCs.Update(id, bookIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _DataPOCs.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _DataPOCs.Remove(book.Id);

            return NoContent();
        }
    }
}
