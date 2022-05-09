using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyData {
    public string name;
    public int hp;
    public int attack;
    public int deffence;
    public int speed;
    public GameObject enemyObject;
}

[CreateAssetMenu(fileName="EnemyDataBase", menuName="DataBase/enemy")]
public class EnemyDataBase : ScriptableObject {
    public List<EnemyData> enemyDataBase = new List<EnemyData>();
}
