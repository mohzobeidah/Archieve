using AutoMapper;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archieve.Servcies
{
    public class MapperService: Profile
    {
        public MapperService()
        {
            CreateMap<Classification, ClassificationVM>().ReverseMap();
            CreateMap<PostType, PostTypeVM>().ReverseMap();
            CreateMap<Security, SecurityVM>().ReverseMap();
            CreateMap<Status, StatusVM>().ReverseMap();
            CreateMap<MailType, MailTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<MailArchive, MailArchiveVM>().ReverseMap();
            CreateMap<WorkPlace, WorkPlaceVM>().ReverseMap();
            CreateMap<MailArchive, MailArchiveVM>().ReverseMap();







        }
    }
  }

