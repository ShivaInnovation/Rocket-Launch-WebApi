using Rocket.Launch.Dto;
using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Rocket.Launch.Models.Extensions
{
    public static class RocketExtensions
    {
        public static RocketDTO TransformToDto(this RocketMdl model)
        {
            Mapper.CreateMap<RocketMdl, RocketDTO>();
            RocketDTO dto = Mapper.Map<RocketDTO>(model);
            return dto;
        }

        public static IEnumerable<RocketDTO> TransformToDto(this IEnumerable<RocketMdl> model)
        {
            foreach (RocketMdl mdl in model)
            {
                yield return mdl.TransformToDto();
            }
        }
    }
}
