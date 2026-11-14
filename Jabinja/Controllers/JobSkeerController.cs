using Jabinja.Data;
using Jabinja.Dto.Employer;
using Jabinja.Dto.JobSkeer;
using Jabinja.Entity;
using Jabinja.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jabinja.Controllers;


[Route("api/[controller]")]
[ApiController]
public class JobSkeerController(
    ApplicationDbContext context,
    IPasswordHasherService passwordHasher) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> Create(CreateJobSkeerRequestDto request)
    {

        var normalized = request.Email.Trim().ToUpper();
        if (await context.JobSeekers.AnyAsync(x => x.Email == normalized))
        {
            return BadRequest("این ایمیل قبلا به ثبت رسیده است");
        }

        var jobSkeer = new JobSeeker
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            PasswordHash = passwordHasher.Hash(request.Password)
        };

       


        context.JobSeekers.Add(jobSkeer);
        await context.SaveChangesAsync();
        return Created($"api/jobSkeer/{jobSkeer.Id}", new

        {
            Id = jobSkeer.Id,
            FirstName = jobSkeer.FirstName,
            LastName = jobSkeer.LastName,
            Email =jobSkeer.Email,
            PhoneNumber = jobSkeer.PhoneNumber
        });

    }


    [HttpPut]
    public async Task<ActionResult> Update(UpdateJobSkeerRequestDto request)
    {
        var normalized = request.Email.Trim().ToUpper();
        if (await context.JobSeekers.AnyAsync(x => x.Id != request.Id && x.Email == normalized))
        {
            return BadRequest("این ایمیل قبلا به ثبت رسیده است");

        }
        var jobSkeer = await context.JobSeekers
            .FirstOrDefaultAsync(x => x.Id == request.Id);
        if (jobSkeer == null)
        {
            return NotFound();
        }

        jobSkeer.FirstName = request.FirstName;
        jobSkeer.LastName = request.LastName;
        jobSkeer.Email = request.Email;
        jobSkeer.PhoneNumber = request.PhoneNumber;
        jobSkeer.PasswordHash = passwordHasher.Hash(request.Password);

        await context.SaveChangesAsync();

        return NoContent();

    }


    [HttpGet]
    public async Task<ActionResult>Get()
    {
        var jobSeekers = await context.JobSeekers
            .Select(x => new GetJobSkeerRequestDto
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
              
            })
            .ToListAsync();

        return Ok();
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetById(int id)
    {
        var jobSeeker = await context.JobSeekers
            .Where(x => x.Id == id)
            .Select(x => new GetJobSkeerRequestDto
            {

                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
              
            })
            .FirstOrDefaultAsync();

        if (jobSeeker == null)
        {
            return NotFound("کارجو پیدا نشد");
        }

        return Ok();
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var jobSeeker = await context.JobSeekers
            .FirstOrDefaultAsync(x => x.Id == id);

        if (jobSeeker == null)
        {
            return NotFound("کارجو پیدا نشد");
        }

        context.JobSeekers.Remove(jobSeeker);

        await context.SaveChangesAsync();

        return NoContent();
    }

}