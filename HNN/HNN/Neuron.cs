﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNN
{
    public class Neuron
    {
        private int state;
        public int State
        {
            get { return state; }
            set { state = value; }

        }

        public Neuron()
        {
            int r = new Random().Next(2);
            switch (r)
            {
                case 0: state = NeuronStates.AlongField; break;
                case 1: state = NeuronStates.AgainstField; break;

            }
        }

        public bool ChangeState(Double field)
        {
            bool res = false;
            if (field * this.State < 0)
            {
                this.state = -this.state;
                res = true;
            }
            return res;
        }
    }
}
