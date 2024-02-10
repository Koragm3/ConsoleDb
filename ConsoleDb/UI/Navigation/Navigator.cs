using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb.UI.Navigation
{
    internal class Navigator
    {
        public void NatigateTo(IUserInterface newUi)
        {
            
            newUi.Render();
        }
    }
}
