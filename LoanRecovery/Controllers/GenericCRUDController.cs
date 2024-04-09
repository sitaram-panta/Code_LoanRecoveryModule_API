using LoanRecovery.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanRecovery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [EnableCors("MyPolicy")]
    public abstract class GenericCRUDController<MainRepo, MainEntity, PKType> : ControllerBase
        where MainEntity: class
        where MainRepo : _IAbsGenericRepo<MainEntity, PKType>
    {
        protected readonly MainRepo _mainRepo;
        public GenericCRUDController(MainRepo mainRepo) 
        {
            _mainRepo = mainRepo; 
        }

        [HttpGet]
        public virtual ActionResult<IQueryable<MainEntity>> GetList()
        {
            var items =  _mainRepo.GetList().ToList();

            return Ok(items);
        }


        [HttpGet("{id}")]
        public virtual async Task<ActionResult<MainEntity>> GetDetails(PKType id)
        {
            var item = await _mainRepo.GetDetails(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<ActionResult<MainEntity>> Create(MainEntity data)
        {
            var createdData = await _mainRepo.Create(data);
            return Ok(createdData);

        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult<MainEntity>> Update(PKType id, MainEntity updatedData)
        {
            if (updatedData == null)
            {
                return NotFound("Entity Cannot be Null");
            }
            var updatedItem = await _mainRepo.Update(id, updatedData);
            if (updatedItem == null)
            {
                return NotFound($"Entity with Id{id} not found");
            
            }
            
            return Ok(updatedItem);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<MainEntity>> Delete(PKType id)
        {
            var deletedItem = await _mainRepo.Delete(id);
            if (deletedItem == null)
            { 
                return NotFound(id);
            }
            return Ok(deletedItem);
        }
    }
}
