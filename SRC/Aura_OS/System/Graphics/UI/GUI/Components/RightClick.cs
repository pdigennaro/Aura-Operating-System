/*
* PROJECT:          Aura Operating System Development
* CONTENT:          Window class
* PROGRAMMERS:      Valentin Charbonnier <valentinbreiz@gmail.com>
*/

using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;

namespace Aura_OS.System.Graphics.UI.GUI.Components
{
    public class RightClickEntry : Button
    {
        public const int ConstHeight = 16 + 4;

        public RightClickEntry(string text, int x, int y, int width) : base(text, x, y, width, ConstHeight)
        {
        }

        public override void Update()
        {
            base.Update();
        }
    }

    public class RightClick : Window
    {
        public List<RightClickEntry> Entries;
        public bool Opened = false;

        public RightClick(int x, int y, int width, int height) : base(x, y, width, height)
        {
            Borders = false;
            Entries = new List<RightClickEntry>();
        }

        public override void Update()
        {
            base.Update();

            int currentY = Y;
            foreach (var entry in Entries)
            {
                entry.X = X;
                entry.Y = currentY;
                entry.Update();

                currentY += entry.Height;
            }
        }
    }
}