// See https://aka.ms/new-console-template for more information
using Evaluator.logic;

Console.WriteLine("Expresions Evaluator");
var expresion = "4*5/(4+6)";
Console.WriteLine($"{expresion}={MyEvaluator.Evaluate(expresion)}");
