using System;
using Microsoft.Extensions.DependencyInjection;
using UtManager.Core.Persistence;

namespace UtManager.Infrastructure.Persistence.Repositories
{
    internal sealed class DatabaseService : IDatabaseService
    {
        public DatabaseService(IPlayersRepository playersRepository)
        {
            PlayersRepository = playersRepository;
        }

        public IPlayersRepository PlayersRepository { get; }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}