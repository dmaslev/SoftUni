using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Core;
using WinterIsComing.Core.Commands;

namespace WinterIsComing
{
    class ExtendedCommandDispatcher : CommandDispatcher
    {
        public override void DispatchCommand(string[] commandArgs)
        {
            base.DispatchCommand(commandArgs);
        }

        public override void SeedCommands()
        {
            base.SeedCommands();
            this.commandsByName["toggle-effector"] = new ToggleEffectorCommand(this.Engine);
        }
    }
}
