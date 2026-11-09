using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

[Route("api/[controller]")]
[ApiController]
public class AlumnosController : ControllerBase
{
    private readonly MyDbContext _context;
    public AlumnosController(MyDbContext context)
    {
        _context = context;
    }

    // GET: api/Alumno
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Alumno>>> GetAlumno()
    {
        return await _context.Alumnos.ToListAsync();
    }

    // GET: api/Alumno/5
    [HttpGet("{idalumno}")]
    public async Task<ActionResult<Alumno>> GetAlumno(int idalumno)
    {
        var alumno = await _context.Alumnos.FindAsync(idalumno);

        if (alumno == null)
        {
            return NotFound();
        }

        return alumno;
    }

    // PUT: api/Alumno/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{idalumno}")]
    public async Task<IActionResult> PutAlumno(int? idalumno, Alumno alumno)
    {
        if (idalumno != alumno.idAlumno)
        {
            return BadRequest();
        }

        _context.Entry(alumno).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AlumnoExists(idalumno))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Alumno
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Alumno>> PostAlumno(Alumno alumno)
    {
        _context.Alumnos.Add(alumno);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAlumno", new { idalumno = alumno.idAlumno }, alumno);
    }

    // DELETE: api/Alumno/5
    [HttpDelete("{idalumno}")]
    public async Task<IActionResult> DeleteAlumno(int? idalumno)
    {
        var alumno = await _context.Alumnos.FindAsync(idalumno);
        if (alumno == null)
        {
            return NotFound();
        }

        _context.Alumnos.Remove(alumno);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AlumnoExists(int? idalumno)
    {
        return _context.Alumnos.Any(e => e.idAlumno == idalumno);
    }
}
