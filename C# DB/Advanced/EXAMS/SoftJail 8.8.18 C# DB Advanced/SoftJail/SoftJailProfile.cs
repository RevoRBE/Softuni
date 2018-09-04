namespace SoftJail
{
    using System;
    using System.Globalization;

    using AutoMapper;

    using SoftJail.Data.Models;
    using SoftJail.DataProcessor.ExportDto;

    public class SoftJailProfile : Profile
    {
        // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE THIS CLASS
        public SoftJailProfile()
        {
            CreateMap<Department, DepartmentDTO>()
                .ForMember(a =>
                    a.Name, n =>
                        n.MapFrom(dto => dto.Name));
            CreateMap<CellDTO, Cell>()
                .ForMember(c =>
                    c.CellNumber, cn =>
                        cn.MapFrom(dto =>
                            dto.CellNumber))
                .ForMember(w =>
                    w.HasWindow, hw =>
                        hw.MapFrom(dto =>
                            dto.HasWindow));
        }
    }
}
