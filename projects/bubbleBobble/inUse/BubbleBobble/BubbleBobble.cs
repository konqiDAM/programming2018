﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BubbleBobble
{
    public void Run()
    {
        // TO DO
    }

    public static void Main()
    {
        bool fullScreen = false;
        SdlHardware.Init(1024, 720, 24, fullScreen);

        WelcomeScreen w = new WelcomeScreen();
        w.Run();

        Game g = new Game();
        g.Run();
    }
}
