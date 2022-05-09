using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EvolutionData {
    public string name;
    public int hp;
    public int attack;
    public int deffence;
    public int speed;
}

[CreateAssetMenu(fileName="EvolutionDataBase", menuName="DataBase/evolution")]
public class EvolutionDataBase : ScriptableObject {
    public List<EvolutionData> evolutionDataBase = new List<EvolutionData>();
}
