using System;
using System.Collections.Generic;

namespace IntroductionToCsharp
{
    class Program
    {
        public static void Main()
        {
            //Dictionary<string, string> capitals = new Dictionary<string, string>();

            //capitals.Add("Alabama", "Montgomery");
            //capitals.Add("Alaska", "Juneau");
            //capitals.Add("Arizona", "Phoenix");
            //capitals.Add("Massachusetts", "Boston");
            //capitals.Add("Wyoming", "Cheyenne");

            //string capitalOfMass = capitals["Massachusetts"];
            //Console.WriteLine("The capital of Massachusetts is {0}", capitalOfMass);

            Dictionary<string, State> theStates = State.GetStates();

            //string capitalOfAlaska = theStates["Alaska"].Capital;
            //int populationOfAlaska = theStates["Alaska"].Population;
            //int sizeOfAlaska = theStates["Alaska"].Size;

            State theState = theStates["Alaska"];

            Console.WriteLine("The Capital of Alaska is {0}, its Population is {1} and its Size is {2} Square Miles",
                               theState.Capital, theState.Population, theState.Size);

        }
    }

        public class State
        {
            public string Capital { get; set; }
            public int Population { get; set; }
            public int Size { get; set; }

            public State(string capital, int pop, int size)
            {
                this.Capital = capital;
                this.Population = pop;
                this.Size = size;
            }

            public static Dictionary<string, State> GetStates()
            {
                Dictionary<string, State> states = new Dictionary<string, State>();

                State theState = new State("Montgomery", 123456, 123);
                states.Add("Alabama", theState);

                theState = new State("Juneau", 3983282, 3833);
                states.Add("Alaska", theState);

                return states;
            }
        }
}

