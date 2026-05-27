using AutoMapper;
using Sistema.Proctor.Data.Entities;
using Sistema.Proctor.WinForm.Dto;

namespace Sistema.Proctor.WinForm.Data;

public class LimiteLiquidoProfile : Profile
{
    public LimiteLiquidoProfile()
    {
        CreateMap<LimiteLiquido, LimiteLiquidoDto>().ReverseMap();
    }
}