﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck a = new Deck();

            Player player = new Player();
            player.Start();
        }
        
    }
}
