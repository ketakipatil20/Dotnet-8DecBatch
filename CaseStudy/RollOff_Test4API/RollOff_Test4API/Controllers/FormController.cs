using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RollOff_Test4API.Models.Domain;
using RollOff_Test4API.Models.DTO;
using RollOff_Test4API.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RollOff_Test4API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
            private readonly IFormRepository formRepository;
            private readonly IMapper mapper;

            public FormController(IFormRepository formRepository, IMapper mapper)
            {
                this.formRepository = formRepository;
                this.mapper = mapper;
            }

            [HttpPost]
            public async Task<IActionResult> AddEmployeeForm(FormTableDTO formTable)
            {
                //DTO to Model
                var employeeForm = mapper.Map<FormTable>(formTable);

                //Pass Detail to Repository
                var response = await formRepository.AddFormAsync(employeeForm);

                //Convert back to DTO
                var formTableDTO = mapper.Map<FormTableDTO>(response);

                return Ok(formTableDTO);
            }

            [HttpGet]
            public async Task<IActionResult> GetAllEmployeesForms()
            {
                var formDetails = await formRepository.GetAllFormsAsync();

                //return DTO

                var formDetailsDTO = mapper.Map<List<FormTableDTO>>(formDetails);

                return Ok(formDetailsDTO);
            }

            [HttpDelete]
            [Route("{ggid}")]
            public async Task<IActionResult> DeleteEmployeeForm(double ggid)
            {
                var employee = await formRepository.DeleteFormAsync(ggid);
                if (employee == null)
                {
                    return NotFound();
                }
                return Ok(employee);
            }

            [HttpPut]
            [Route("{ggid}")]
            public async Task<IActionResult> UpdateEmployeeForm(double ggid, UpdateFormDTO updateFormDTO)
            {
                var employee = mapper.Map<FormTable>(updateFormDTO);
                var emp = await formRepository.UdateFormAsync(ggid, employee);
                if (emp == null)
                {
                    return NotFound();
                }
                var empDTO = mapper.Map<UpdateFormDTO>(emp);
                return Ok(empDTO);

            }
        }
}
