using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMake.Data
{
    internal class Workspace
    {
        List<World> worlds=new List<World>();
        List<Schematic> schematics = new List<Schematic>();
        List<Script> scripts = new List<Script>();
    }
}
