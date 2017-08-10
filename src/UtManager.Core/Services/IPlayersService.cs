using System.Collections;
using System.Collections.Generic;
using UtManager.Core.Entities;

namespace UtManager.Core.Services
{
    public interface IPlayersService
    {
        IList<Player> GetAll();

        Player CreatePlayer(Player player);        
    }
}