using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvesAndRabbitsSimulation.Engine;

namespace WolvesAndRabbitsSimulation.Simulation
{
    class Grass : GameObject
    {
        public const int PATCH_SIZE = 2;//tamaño del pasto

        private int growth;
        private int ticks = 0;
        
        public int Growth//actualiza la vida del apsto y el color
        {
            get { return growth; }
            set
            {
                growth = value;
                if (growth > 255) { growth = 255; }
                else if (growth < 0) { growth = 0; }
                Color = Color.FromArgb(growth, 0, 255, 0);//degradado de color = growth
            }
        }

        public override Rectangle Bounds//tamaño del pasto
        {
            get { return new Rectangle(Position, new Size(PATCH_SIZE, PATCH_SIZE)); }
        }

        public override void UpdateOn(World world)//se actualiza el tiempo y el pasto aumenta 10
        {
            if (++ticks > 10)
            {
                ticks = 0;
                Growth += 10;
            }
        }
    }
}
