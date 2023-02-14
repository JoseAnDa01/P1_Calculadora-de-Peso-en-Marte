using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace MyCompany.Intranet.Console;

public static class Program{
    public static void Main(string[] args){
        float weightM = 0;

        System.Console.WriteLine("Please enter the Weight");
        Single.TryParse(System.Console.ReadLine(), out weightM);        

        var person = new Person{Weight = weightM};

        var service = new WeightService();
        var manager = new WeightManager(service);

        Weight weight = manager.GetWeight(person);

        System.Console.WriteLine($"Peso en Marte {weight.WeightM}");
    }
}