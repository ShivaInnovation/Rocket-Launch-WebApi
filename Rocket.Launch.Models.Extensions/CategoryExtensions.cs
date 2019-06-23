using AutoMapper;
using Rocket.Launch.Dto;
using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Models.Extensions
{
    public static class CategoryExtensions
    {
        public static CategoryDTO TransformToDto(this CategoryMdl model)
        {
            Mapper.CreateMap<CategoryMdl, CategoryDTO>();
            CategoryDTO dto = Mapper.Map<CategoryDTO>(model);
            return dto;
        }

        public static IEnumerable<CategoryDTO> TransformToDto(this IEnumerable<CategoryMdl> model)
        {
            foreach (CategoryMdl mdl in model)
            {
                yield return mdl.TransformToDto();
            }
        }
    }
}
