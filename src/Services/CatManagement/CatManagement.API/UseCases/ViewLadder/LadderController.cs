using CatManagement.Domain.CatObject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatManagement.API.UseCases.ViewLadder
{
    [Route("api/[controller]")]
    public class LadderController : Controller
    {
        private readonly ICatReadOnlyRepository _catReadOnlyRepository;
        private readonly ICatWriteOnlyRepository _catWriteOnlyRepository;

        public LadderController(
            ICatReadOnlyRepository catReadOnlyRepository,
            ICatWriteOnlyRepository catWriteOnlyRepository)
        {
            _catReadOnlyRepository = catReadOnlyRepository;
            _catWriteOnlyRepository = catWriteOnlyRepository;
        }
        
        public async Task<IActionResult> Index()
        {
            return new ObjectResult(await _catReadOnlyRepository.Get());
        }
    }
}
