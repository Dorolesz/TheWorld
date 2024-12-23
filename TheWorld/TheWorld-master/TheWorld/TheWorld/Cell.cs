﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }

        public List<Creature> Inhabitants { get; set; } = new List<Creature>();
        public Plant Plant { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void AddCreature(Creature creature)
        {
            Inhabitants.Add(creature);
        }

        public void RemoveCreature(Creature creature)
        {
            Inhabitants.Remove(creature);
        }

        public void AddPlant(Plant plant)
        {
            if (Plant == null)
            {
                Plant = plant;
            }
        }
        public void RemovePlant(Plant plant)
        {
            this.Plant = null;
        }
    }
}
