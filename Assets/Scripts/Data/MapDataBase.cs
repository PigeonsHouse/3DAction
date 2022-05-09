using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class MapData {
    public MapType mapType;
    public string description;
    public string sceneName;
}

[CreateAssetMenu(fileName="MapDataBase", menuName="DataBase/map")]
public class MapDataBase : ScriptableObject {
    public List<MapData> mapDataBase = new List<MapData>();
}
