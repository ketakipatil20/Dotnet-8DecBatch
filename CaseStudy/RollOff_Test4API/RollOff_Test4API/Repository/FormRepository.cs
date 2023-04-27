using Microsoft.EntityFrameworkCore;
using RollOff_Test4API.Data;
using RollOff_Test4API.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RollOff_Test4API.Repository
{
    public class FormRepository: IFormRepository
    {
        private readonly RollOff4DbContext context;

        public FormRepository(RollOff4DbContext context)
        {
            this.context = context;
        }
        public async Task<FormTable> AddFormAsync(FormTable formTable)
        {
            await context.AddAsync(formTable);
            await context.SaveChangesAsync();
            return formTable;
        }
        public async Task<FormTable> DeleteFormAsync(double ggid)
        {
            var employee = await context.FormTables.FirstOrDefaultAsync(x => x.GlobalGroupID == ggid);
            if (employee == null)
            {
                return employee;
            }
            context.FormTables.Remove(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<FormTable>> GetAllFormsAsync()
        {
            return await context.FormTables.ToListAsync();

        }

        public async Task<FormTable> UdateFormAsync(double ggid, FormTable form)
        {
            var existingemployee = await context.FormTables.FirstOrDefaultAsync(x => x.GlobalGroupID == ggid);
            if (existingemployee == null)
            {
                return existingemployee;
            }

            existingemployee.EmployeeNumber = form.EmployeeNumber;
            existingemployee.Name = form.Name;
            existingemployee.PrimarySkill = form.PrimarySkill;
            existingemployee.LocalGrade = form.LocalGrade;
            existingemployee.ProjectCode = form.ProjectCode;
            existingemployee.ProjectName = form.ProjectName;
            existingemployee.Practice = form.Practice;
            existingemployee.RollOffEndDate = form.RollOffEndDate;
            existingemployee.ReasonForRollOff = form.ReasonForRollOff;
            existingemployee.ThisReleaseNeedsBackfillIsBackfilled = form.ThisReleaseNeedsBackfillIsBackfilled;
            existingemployee.PerformanceIssue = form.PerformanceIssue;
            existingemployee.Resigned = form.Resigned;
            existingemployee.UnderProbation = form.UnderProbation;
            existingemployee.LongLeave = form.LongLeave;
            existingemployee.TechnicalSkills = form.TechnicalSkills;
            existingemployee.Communication = form.Communication;
            existingemployee.RoleCompetencies = form.RoleCompetencies;
            existingemployee.Remarks = form.Remarks;
            existingemployee.RelevantExperienceYears = form.RelevantExperienceYears;
            existingemployee.Status = form.Status;
            existingemployee.RequestDate = form.RequestDate;

            await context.SaveChangesAsync();
            return existingemployee;

        }
    }
}
