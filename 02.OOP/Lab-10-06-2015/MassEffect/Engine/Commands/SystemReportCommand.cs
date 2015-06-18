using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.Engine.Commands
{
    class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            :base(gameEngine)
        {

        }

        public override void Execute(string[] commandArgs)
        {
            string locationName = commandArgs[1];
            var starships = this.GameEngine.Starships
                .Where(s => s.Location.Name == locationName);

            var intactShips = starships
                .Where(s => s.Health > 0)
                .OrderByDescending(s => s.Health)
                .ThenByDescending(s => s.Shields);

            StringBuilder result = new StringBuilder();
            result.AppendLine("Intact ships:");
            result.AppendLine(intactShips.Any() ? string.Join("\n", intactShips) : "N/A");

            var destroyed = this.GameEngine.Starships
                .Where(s => s.Location.Name == locationName);

            var destroyedShips = destroyed
                .Where(d => d.Health <= 0)
                .OrderBy(d => d.Name);

            result.AppendLine("Destroyed ships:");
            result.Append(destroyedShips.Any() ? string.Join("\n", destroyedShips) : "N/A");
            Console.WriteLine(result.ToString());
        }
    }
}
