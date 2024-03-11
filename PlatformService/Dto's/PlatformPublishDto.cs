using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Dto_s
{
    public record PlatformPublishDto
    {
        public int Id { get; init; }
        public int Name { get; init; }
        public int Event { get; init; }
    }
}