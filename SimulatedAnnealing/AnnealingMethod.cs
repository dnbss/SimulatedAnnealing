using System.Numerics;
using System.Runtime.ExceptionServices;

namespace SimulatedAnnealing
{
    public class AnnealingMethod
    {
        public List<(List<int> Path, double Temperature)> GetResult(
            double[,] matrix, 
            double maxTemperature, 
            double minTemperature,
            double C)
        {
            var result = new List<(List<int>, double)>();

            var state = InitialState(matrix.GetLength(0));

            var currentTemperature = maxTemperature;

            int i = 0;

            Random random = new Random();

            while (currentTemperature > minTemperature && currentTemperature <= maxTemperature)
            {
                result.Add(new (new List<int>(state), currentTemperature));

                var newState = GenerateState(state);

                i++;

                currentTemperature = NewTemperature(maxTemperature, i);

                double deltaEnergy = EnergyFunc(matrix, newState) - EnergyFunc(matrix, state);

                if (deltaEnergy <= 0)
                {
                    state = newState;

                    continue;
                }

                double probability = TransitionStateProbability(C, deltaEnergy, currentTemperature);

                if (probability > random.NextDouble() * C)
                {
                    state = newState;
                }
            }

            return result;
        }
        
        private double NewTemperature(double maxTemperature, int i) => maxTemperature / i;

        private double TransitionStateProbability(double C, double deltaEnergy, double temperature) 
            => Math.Pow(Math.E, -deltaEnergy / temperature) * C;

        public double EnergyFunc(double[,] matrix, List<int> state)
        {
            double result = 0;

            for (int i = 0; i < state.Count; i++)
            {
                result += matrix[state[i], state[(i + 1) % state.Count]];
            }

            return result;
        }

        private List<int> GenerateState(List<int> oldState)
        {
            List<int> state = new List<int>(oldState);

            Random random = new Random();

            int first = 0;

            int second = 0;

            do
            {
                first = random.Next(oldState.Count);

                second = random.Next(oldState.Count);

            } while (first == second);

            var t = state[first];

            state[first] = state[second];

            state[second] = t;

            return state;
        }

        private List<int> InitialState(int countVertex)
        {
            List<int> path = new();

            Random random = new Random();

            for (int i = 0; i < countVertex; i++)
            {
                var v = random.Next(countVertex);

                while (path.Contains(v))
                {
                    v = random.Next(countVertex);
                }

                path.Add(v);    
            }

            return path;
        }
    }
}