using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class MapData {
    public MapType mapType;
    public string description;
    public string sceneName;

    public MapType GetMapType(){
        return mapType;
    }

    public string GetDescription(){
        return description;
    }

    public string GetSceneName(){
        return sceneName;
    }
}


[CreateAssetMenu(fileName="MapDataBase", menuName="DataBase/map")]
public class MapDataBase : ScriptableObject {
    public List<MapData> mapDataBase = new List<MapData>();

    public List<MapData> GetMapDataList(){
        return mapDataBase;

    }
}
