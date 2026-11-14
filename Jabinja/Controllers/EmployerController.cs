using Jabinja.Data;
using Jabinja.Dto.Employer;
using Jabinja.Entity;
using Jabinja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace Jabinja.Controllers;

//[Authorize(Employer="Master")]

[Route("api/[controller]")]
[ApiController]
public class EmployerController(
    ApplicationDbContext context,
    IPasswordHasherService passwordHasher) : ControllerBase
{
    
    [HttpPost]
    public async Task<ActionResult> Create(CreateEmployerRequestDto request)
    {
        var email = request.Email.Trim().ToLower();

        if (await context.Employers.AnyAsync(x => x.Email == email))
        {
            return BadRequest("این ایمیل قبلاً ثبت شده است");
        }

        var employer = new Employer
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = email,
            PhoneNumber = request.PhoneNumber,
            PasswordHash = passwordHasher.Hash(request.Password)
        };

        context.Employers.Add(employer);

        await context.SaveChangesAsync();

        return Created($"api/employer/{employer.Id}", new
        {
            FirstName=employer.FirstName,
            LastName=employer.LastName,
            Id=employer.Id,
            Email = employer.Email,
            PhoneNumber = employer.PhoneNumber
        });
    }

    [HttpPut]
    public async Task<ActionResult> Update(UpdateEmployerRequestDto request)
    {
        var email = request.Email.Trim().ToLower();

      
            if (await context.Employers.AnyAsync(x => x.Id != request.Id && x.Email == email))
            
        {
            return BadRequest("این ایمیل قبلاً ثبت شده است");
        }

        var employer = await context.Employers
            .FirstOrDefaultAsync(x => x.Id == request.Id);

        if (employer is null)
        {
            return NotFound();
        }

        employer.FirstName = request.FirstName;
        employer.LastName = request.LastName;
        employer.Email = email;
        employer.PhoneNumber = request.PhoneNumber;
     employer.PasswordHash = passwordHasher.Hash(request.Password);

        await context.SaveChangesAsync();

        return NoContent();
    }


    [HttpGet]
    public async Task<ActionResult> Get()
    {
        
       var employers = await context.Employers
            .Select(x => new GetEmployerRequestDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
                
            })
            .ToListAsync();

        return Ok();
    }

   
    [HttpGet("{id}")]
    public async Task<ActionResult> GetById(int id)
    {

           var employer = await context.Employers
            .Where(x => x.Id == id)
            .Select(x => new GetEmployerRequestDto
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
                
            })
            .FirstOrDefaultAsync();

        if (employer is null)
        {
            return NotFound();
        }

        return Ok();
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {

        var employer = await context.Employers
            .FirstOrDefaultAsync(x => x.Id == id);

        if (employer is null)
        {
            return NotFound();
        }

        context.Employers.Remove(employer);

        await context.SaveChangesAsync();

        return NoContent();
    }
}