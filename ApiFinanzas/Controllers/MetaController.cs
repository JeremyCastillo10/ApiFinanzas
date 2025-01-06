using ApiFinanzas.DAL;
using ApiFinanzas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs.Meta;

namespace ApiFinanzas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaController : ControllerBase
    {
        private readonly Contexto _Contexto;

        public MetaController(Contexto contexto)
        {
            _Contexto = contexto;
        }

        [HttpPost]
        public async Task<ActionResult<int>> GuardarMetaFinanciera([FromBody] MetaFinanciera_DTO metaFinanciera_DTO)
        {
            try
            {
                if (metaFinanciera_DTO.MetaId != 0)
                {
                    // Actualizar meta existente
                    var meta = await _Contexto.MetaFinancieras
                        .Include(m => m.Usuario)
                        .FirstOrDefaultAsync(m => m.MetaId == metaFinanciera_DTO.MetaId);

                    if (meta == null)
                    {
                        return NotFound();
                    }

                    meta.Nombre = metaFinanciera_DTO.Nombre;
                    meta.MontoMeta = metaFinanciera_DTO.MontoMeta ?? meta.MontoMeta;
                    meta.MontoAhorrado = metaFinanciera_DTO.MontoAhorrado ?? meta.MontoAhorrado;
                    meta.FechaMeta = metaFinanciera_DTO.FechaMeta;
                    meta.Estado = metaFinanciera_DTO.Estado ?? meta.Estado;
                    meta.FechaActualizacion = DateTime.Now;

                    await _Contexto.SaveChangesAsync();
                }
                else
                {
                    // Crear nueva meta financiera
                    var usuario = await _Contexto.Usuarios.FindAsync(metaFinanciera_DTO.UserId);
                    if (usuario == null)
                    {
                        return BadRequest("Usuario no encontrado");
                    }

                    var meta = new MetaFinanciera
                    {
                        Usuario = usuario,
                        Nombre = metaFinanciera_DTO.Nombre,
                        MontoMeta = metaFinanciera_DTO.MontoMeta ?? 0,
                        MontoAhorrado = metaFinanciera_DTO.MontoAhorrado ?? 0,
                        FechaMeta = metaFinanciera_DTO.FechaMeta,
                        Estado = metaFinanciera_DTO.Estado ?? "En Progreso",
                        FechaCreacion = DateTime.Now,
                        FechaActualizacion = DateTime.Now
                    };

                    _Contexto.MetaFinancieras.Add(meta);
                    await _Contexto.SaveChangesAsync();
                }

                return Ok(0);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocurrió un error interno");
            }
        }
        [HttpGet("GetMetasPorUsuario/{userId}")]
        public async Task<ActionResult<List<MetaFinanciera_DTO>>> GetMetasPorUsuario(string userId)
        {
            try
            {
                // Buscar usuario en la base de datos
                var usuario = await _Contexto.Usuarios.FindAsync(userId);
                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado");
                }

                // Filtrar las metas que pertenecen al usuario
                var metas = await _Contexto.MetaFinancieras
     .Include(m => m.Usuario) // Cargar la relación Usuario
     .Where(m => m.Usuario.Id == userId)
     .Select(m => new MetaFinanciera_DTO
     {
         MetaId = m.MetaId,
         Nombre = m.Nombre,
         MontoMeta = m.MontoMeta,
         MontoAhorrado = m.MontoAhorrado,
         FechaMeta = m.FechaMeta,
         Estado = m.Estado,
         UserId = m.Usuario.Id
     })
     .ToListAsync();


                if (metas == null || !metas.Any())
                {
                    return NotFound("No se encontraron metas financieras para este usuario");
                }

                return Ok(metas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocurrió un error interno");
            }
        }

    }
}
