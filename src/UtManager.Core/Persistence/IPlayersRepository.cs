using System.Collections.Generic;
using UtManager.Core.Entities;
using UtManager.Utils;

namespace UtManager.Core.Persistence
{
    public interface IPlayersRepository
    {
        [NotNull]
        IList<Player> GetAll();
    }
}