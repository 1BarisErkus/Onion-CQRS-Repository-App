using EnocaChallengeApp.Application.Features.Commands.Updates.UpdateFirm;
using EnocaChallengeApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Application.Interfaces.Repository
{
    public interface IFirmRepository : IGenericRepositoryAsync<Firm>
    {
    }
}
