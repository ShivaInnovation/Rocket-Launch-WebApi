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
    public static class SatelliteExtensions
    {
        public static SatelliteDTO TransformToDto(this SatelliteMdl model)
        {
            Mapper.CreateMap<SatelliteMdl, SatelliteDTO>();
            SatelliteDTO dto = Mapper.Map<SatelliteDTO>(model);
            return dto;
        }

        public static IEnumerable<SatelliteDTO> TransformToDto(this IEnumerable<SatelliteMdl> model)
        {
            foreach (SatelliteMdl mdl in model)
            {
                yield return mdl.TransformToDto();
            }
        }
    }
}
