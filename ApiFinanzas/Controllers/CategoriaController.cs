using ApiFinanzas.DAL;
using ApiFinanzas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DTOs.Categoria;

namespace ApiFinanzas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly Contexto _db;
        public CategoriaController(Contexto db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria_DTO>>> GetAllArticulos()
        {
            var articulos = await _db.Categorias
                .Where(a => a.Eliminado == false)
                .Select(a => new Categoria_DTO
                {
                    Id = a.Id,
                    Nombre = a.Nombre,
                })
                .ToListAsync();

            return Ok(articulos);
        }
        [HttpPost("Savecategoria")]

        public async Task<ActionResult<int>> GuardarCategoria([FromBody] Categoria_DTO categoria_DTO)
        {




            if (categoria_DTO.Id > 0)
            {
                var categoria = await _db.Categorias.FindAsync(categoria_DTO.CategoriaId);
                categoria.Nombre = categoria_DTO.Nombre;
                categoria.FechaActualizacion = DateTime.Now;

                await _db.SaveChangesAsync();

            }
            else
            {
                var categoria = new Categoria();

                categoria.Nombre = categoria_DTO.Nombre;
                categoria.FechaCreacion = DateTime.Now;
                categoria.Eliminado = false;

                _db.Categorias.Add(categoria);
                await _db.SaveChangesAsync();
            }
            return 0;
        }
    }
}
