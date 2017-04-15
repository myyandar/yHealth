using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myyandar.yHealth.Patient.Dto;
using myyandar.yHealth.Users.Dto;

namespace myyandar.yHealth.Patient
{
    public interface IPatientAppService : IApplicationService
    {
        Task <ListResultDto<PatientListDto>> GetPatients();

        void CreatePatient(CreatePatientInput input);

        Task UpdatePatient(UpdatePatientInput input);

        Task <ListResultDto<PatientListDto>> GetPatients(GetPatientsInput input);
    }
}