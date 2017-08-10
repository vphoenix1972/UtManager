using System.Collections.Generic;
using UtManager.Core.Entities;
using UtManager.Core.Persistence;

namespace UtManager.Infrastructure.Persistence.Repositories
{
    internal sealed class PlayersRepository : IPlayersRepository
    {
        public IList<Player> GetAll()
        {
            return new List<Player>();
        }
    }
}