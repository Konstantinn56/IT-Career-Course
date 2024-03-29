﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gammmme
{
    public class CapacityList
    {
     
        private Pair[] pairs;
        private const int InitialCpacity = 2;
        private int startIndex = 0;
        private int nextIndex = 0;

        public CapacityList(int capacity = InitialCpacity)
        {
            this.pairs = new Pair[capacity];
        }
        public int Count { get => this.pairs.Length;}

        public void Add(Pair pair)
        {
            if(this.nextIndex >= this.Count)
            {
                this.pairs[startIndex] = SumIntervalPairs();
                this.startIndex++;
                nextIndex = startIndex;
            }
            this.pairs[this.nextIndex] = pair;
            this.nextIndex++;
        }

        public Pair Sum()
        {
            Pair pair = new Pair(0,0);
            for (int i = 0; i < startIndex; i++)
            {
                pair.First += this.pairs[i].First;
                pair.Last += this.pairs[i].Last;
            }
            return pair;
        }

        private Pair SumIntervalPairs()
        {
            Pair newPair = new Pair(0, 0);
            for (int i = startIndex; i < nextIndex; i++)
            {
                newPair.First += this.pairs[i].First;
                newPair.Last += this.pairs[i].Last;
            }
            return newPair;
        }

        public void PrintCurrentState()
        {
            for (int i = 0; i < this.nextIndex; i++)
            {
                Console.WriteLine(this.pairs[i]);
            }
        }
    }

    
}
