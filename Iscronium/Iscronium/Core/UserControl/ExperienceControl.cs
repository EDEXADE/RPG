using Iscronium.Models.Units;

namespace Iscronium.Core.UserControl
{
    public class ExperienceControl
    {
        public void AddExp(Player player, int exp) => player.AddExp(exp);
    }
}
