using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS4MacroAPI;

namespace SwordGlitch
{
    public class Script : ScriptBase
    {
		public Script()
		{
			Config.Name = "Sword Glitch Macro";
			Config.LoopDelay = 1;
		}

		public override void Start()
		{
			base.Start();
		}

		public override void Update()
		{
			Press(new DualShockState() { Square = true }, 250);
		}
	}
}
