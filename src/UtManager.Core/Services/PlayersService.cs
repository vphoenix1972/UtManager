using System.Collections.Generic;
using UtManager.Core.Entities;
using UtManager.Core.Exceptions;
using UtManager.Core.Persistence;

namespace UtManager.Core.Services
{
    internal sealed class PlayersService : IPlayersService
    {
        private readonly IDatabaseService _db;

        public PlayersService(IDatabaseService db)
        {
            _db = db;
        }

        public IList<Player> GetAll()
        {
            return _db.PlayersRepository.GetAll();
        }

        public Player CreatePlayer(Player player)
        {
            throw new UtManagerException(UtManagerErrorCode.Test);
        }
    }
}