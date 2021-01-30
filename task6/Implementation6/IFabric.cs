using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation6
{
    interface IFabric
    {
        string Texture { get; set; }

        int GetLength();
        int GetWeight();
        int GetHeight();
        string GetTexture();
    }
}