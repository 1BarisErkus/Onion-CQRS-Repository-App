using EnocaChallengeApp.Application.Interfaces.Repository;
using EnocaChallengeApp.Domain.Entities;
using EnocaChallengeApp.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnocaChallengeApp.Persistance.Repositories
{
    public class FirmRepository : GenericRepository<Firm>, IFirmRepository
    {
        public FirmRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
