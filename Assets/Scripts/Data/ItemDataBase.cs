using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData {
    public string name;
    public Texture icon;
    public string description;
    public Parameter type;
    public int addition;
}

[CreateAssetMenu(fileName="ItemDataBase", menuName="DataBase/item")]
public class ItemDataBase : ScriptableObject {
    public List<ItemData> itemDataBase = new List<ItemData>();
}
