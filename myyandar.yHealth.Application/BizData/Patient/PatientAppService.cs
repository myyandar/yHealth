using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using myyandar.yHealth.Authorization;
using myyandar.yHealth.Users.Dto;
using Microsoft.AspNet.Identity;
using myyandar.yHealth.EntityFramework.Repositories;
using myyandar.yHealth.Patient.Dto;
using myyandar.yHealth.BizData;
using System;

namespace myyandar.yHealth.Patient
{
    /* THIS IS JUST A SAMPLE. */
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class PatientAppService : yHealthAppServiceBase, IPatientAppService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientAppService(IPatientRepository patientRepository, IPermissionManager permissionManager)
        {
            _patientRepository = patientRepository;
        }

        void IPatientAppService.CreatePatient(CreatePatientInput input)
        {
            Logger.Info("Creating Patientt Record...");
            var patient = new BizData.Patient
            {
                Surname = input.Surname,
                Othernames = input.Othernames,
                Phone = input.Phone,
                HomeAddress = input.HomeAddress,
                WorkAddress = input.WorkAddress,
                Email = input.Email,
                PicPath = input.PicPath,
                NHISCardId = input.NHISCardId,
                PrevVisit = input.PrevVisit,
                IsActive = input.IsActive,
                PrevHosp = input.PrevHosp,
                DateLastVisitPrevHosp = input.DateLastVisitPrevHosp,
                ReasonLastVisitToPrev = input.ReasonLastVisitToPrev,

            };

            _patientRepository.Insert(patient);
        }

        Task<ListResultDto<PatientListDto>> IPatientAppService.GetPatients()
        {
            throw new NotImplementedException();
        }

        Task<ListResultDto<PatientListDto>> IPatientAppService.GetPatients(GetPatientsInput input)
        {
            throw new NotImplementedException();
        }

        Task IPatientAppService.UpdatePatient(UpdatePatientInput input)
        {
            throw new NotImplementedException();
        }
    }
}