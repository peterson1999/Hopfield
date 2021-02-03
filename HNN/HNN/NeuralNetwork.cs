using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNN
{

    class NeuralNetwork
    {

        public List<Neuron> Neurons;
   
        

        int n;
        private List<Neuron> neurons;
        private int[,] T;
        private int m;

        public NeuralNetwork(int n)
        {
            this.n = n;
            neurons = new List<Neuron>(n);
            for (int i = 0; i < n; i++)
            {
                Neuron neuron = new Neuron();
                neuron.State = 0;
                neurons.Add(neuron);
            }

            T = new int[n, n];
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    T[i, j] = 0;
                }
            }
        }

        public void AddPattern(List<Neuron> Pattern)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) T[i, j] = 0;
                    else T[i, j] += (Pattern[i].State * Pattern[j].State);

                }
                m++;
            }
        }

        public void Run(List<Neuron> initialState)
        {
            this.neurons=initialState;
            int k = 1;
            int h = 0;
            while (k != 0)
            {
                k = 0;
                for (int i=0; i < n; i++)
                {
                    h = 0;
                    for (int j = 0; j < n; j++)
                    {
                        h +=T[i,j]* (neurons[j].State);
                    }
                    if (neurons[i].ChangeState(h))
                    {
                        k++;
                        CalculateEnergy();
                        OnEnergyChanged(new EnergyEventArgs(e, i));
                    }
                }
            }
            CalculateEnergy();
        }
    }
}
