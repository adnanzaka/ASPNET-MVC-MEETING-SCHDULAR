using AutoMapper;
using MeetingBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
   public static class Mapper
    {
        public static Meeting MapDTO(this DataAccess.DataSource.Meeting sourceDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataAccess.DataSource.Meeting, Meeting>()
                .ForMember(dto => dto.MeetingId, opt => opt.MapFrom(src => src.MeetingId))
                .ForMember(dto => dto.Month, opt => opt.MapFrom(src => src.Month))
                .ForMember(dto => dto.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dto => dto.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dto => dto.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dto => dto.Organizer, opt => opt.MapFrom(src => src.Organizer))
                .ForMember(dto => dto.MeetingDetails, opt => opt.MapFrom(src => src.MeetingDetails));
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<DataAccess.DataSource.Meeting, Meeting>(sourceDTO);
        }

        public static List<Meeting> MapDTO(this IEnumerable<DataAccess.DataSource.Meeting> sourceDTO)
        {
            return sourceDTO.Select(x => x.MapDTO()).ToList();
        }

        public static MeetingDetail MapDTO(this DataAccess.DataSource.MeetingDetail sourceDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DataAccess.DataSource.MeetingDetail, MeetingDetail>()
                .ForMember(dto => dto.MeetingId, opt => opt.MapFrom(src => src.MeetingId))
                .ForMember(dto => dto.Attendee, opt => opt.MapFrom(src => src.Attendee));
            });
            IMapper mapper = config.CreateMapper();
            return mapper.Map<DataAccess.DataSource.MeetingDetail, MeetingDetail>(sourceDTO);
        }

        public static List<MeetingDetail> MapDTO(this IEnumerable<DataAccess.DataSource.MeetingDetail> sourceDTO)
        {
            return sourceDTO.Select(x => x.MapDTO()).ToList();
        }
    }
}
