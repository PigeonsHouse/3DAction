using UnityEngine;
using System.Collections;

public class GameManager : SingletonMonoBehaviour<GameManager> {
    public void Test(){
        Debug.Log ("シングルトン！");
    }
}
