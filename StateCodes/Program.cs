using System;
using System.Collections.Generic;

namespace StateCodes
{
    class Program
    {
        static void Main()
        {
            var States = new List<State>()
            {
                new State("OH","Ohio"),
                new State("KY", "Kentucky"),
                new State("IN", "Indiana")
            };

            //var State1 = new State("OH", "Ohio");
            //var State2 = new State("IN", "Indiana");
            //States.Add(new State("KY", "Kentucky"));

            //States.Add(State1); States.Add(State2); 

            foreach(State state in States)
            {
                Console.WriteLine($"For {state.Code} the name is: {state.Name}");
            }



            // Build dictionary, and assign a variable to one of its values.
            //var StateCodes = new Dictionary<string, string>()
            //{
            //    ["OH"] = "Ohio",
            //    ["IN"] = "Indiana",
            //    ["KY"] = "Kentucky" // This process is good for initializing list
            //};
            //StateCodes.Add("OH", "Ohio");
            //StateCodes.Add("IN", "Indiana");
            //StateCodes.Add("KY", "Kentucky");

            //var ohio = StateCodes["OH"];
            //Console.WriteLine(ohio);
        }
    }
}
