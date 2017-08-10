using UtManager.Utils;

namespace UtManager.Core.Persistence
{
    public interface IDatabaseService
    {
        [NotNull]
        IPlayersRepository PlayersRepository { get; }

        void SaveChanges();
    }
}