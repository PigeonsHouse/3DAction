using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkillData {
    public string name;
    public Texture icon;
    public string description;
}

[CreateAssetMenu(fileName="SkillDataBase", menuName="DataBase/skill")]
public class SkillDataBase : ScriptableObject {
    public List<SkillData> skillDataBase = new List<SkillData>();
}
