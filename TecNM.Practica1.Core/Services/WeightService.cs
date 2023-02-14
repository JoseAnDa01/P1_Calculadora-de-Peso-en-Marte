using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class WeightService : IWeightService{
    public Weight ProcessWeight(Person person){
        
        var weight = new Weight();

        weight.WeightM = Convert.ToSingle(person.Weight / 9.81) * 3.71;

        return weight;
    }
}