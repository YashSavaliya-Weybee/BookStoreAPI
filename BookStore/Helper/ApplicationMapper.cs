using AutoMapper;
using BookStore.Data;
using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }

    }
}
