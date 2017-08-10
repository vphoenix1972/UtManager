using UtManager.Utils.Entities;

namespace UtManager.Core.Entities
{
    public class Player : IEntity<int?>
    {
        public int? Id { get; set; }

        public string Name { get; set; }
    }
}