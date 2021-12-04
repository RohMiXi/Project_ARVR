using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Player_Controller : MonoBehaviour
{
    public PlayerData playerData;

    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Path.Combine(Application.dataPath, "PlayerData.json");
        File.WriteAllText(path, jsonData);
    }
    [ContextMenu("From Json Data")]
    // void LoadPlayerDataToJson()
    // {
    //     string path = Path.Combine(Application.dataPath, "playerData.json");
    // }

}
[System.Serializable]
public class PlayerData
{
    public string name;
    public int age;
    public int level;
    public bool isDeed;
    public string[] items;
}
