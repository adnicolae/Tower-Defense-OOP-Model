﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Level
    { 
        private readonly IInvader[] _invaders;

        // The level needs to know about towers
        // the player can set this array after the level
        // is created
        public Tower[] Towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        // Returns: true if the player wins, false otherwise.
        public bool Play()
        {
            // Run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                // Each tower has the opportunity to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                // Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}
