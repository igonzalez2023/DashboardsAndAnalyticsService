using Application.DTOs;
using Application.Features.ReportBase.Commands;
using Application.Features.ReportBase.Commands.CreateReportBaseCommand;
using Application.Features.ReportBase.Commands.UpdateReportBaseCommand;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class GeneralProfile : Profile
{
    public GeneralProfile()
    {
        #region Commands

        CreateMap<CreateReportBaseCommand, ReportBase>();
        CreateMap<UpdateReportBaseCommand, ReportBase>();

        #endregion

        #region DTOs

        CreateMap<ReportBaseDto, ReportBase>();

        #endregion
    }
}