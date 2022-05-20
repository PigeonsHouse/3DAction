using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private MapDataBase mapdatabase; //使用するデータベース
    private Dictionary<MapData, int> numofMap = new Dictionary<MapData, int>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<mapdatabase.GetMapDataList().Count; i++){
            numofMap.Add(mapdatabase.GetMapDataList()[i],i);
        }        

        Debug.Log(GetMap("Floor1").GetMapType());

    }

    public MapData GetMap(string serchName){
        return mapdatabase.GetMapDataList().Find(sceneName => sceneName.GetSceneName() == serchName);
    }

}
