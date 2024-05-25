using System;
using System.Collections.Generic;

namespace DominoClasses
{
    public class Boneyard
    {
        private List<Domino> dominos;

        public Boneyard(int maxDots)
        {
            dominos = new List<Domino>();
            for (int i = 0; i <= maxDots; i++)
            {
                for (int j = i; j <= maxDots; j++)
                {
                    dominos.Add(new Domino(i, j));
                }
            }
        }

        public int Count
        {
            get { return dominos.Count; }
        }

        public Domino this[int index]
        {
            get { return dominos[index]; }
            set { dominos[index] = value; }
        }

        public Domino Draw()
        {
            if (dominos.Count == 0)
            {
                throw new InvalidOperationException("The boneyard is empty.");
            }

            Domino topDomino = dominos[0];
            dominos.RemoveAt(0);
            return topDomino;
        }

        public bool IsEmpty()
        {
            return dominos.Count == 0;
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = dominos.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Domino value = dominos[k];
                dominos[k] = dominos[n];
                dominos[n] = value;
            }
        }

        public override string ToString()
        {
            return string.Join(", ", dominos);
        }
    }
}
