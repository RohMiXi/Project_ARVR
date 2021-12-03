using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class playerInformation : MonoBehaviour
{
    public PlayerData playerData;

    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(playerData);
        string path = Path.Combine(Application.dataPath, "PlayerData.json");
        File.WriteAllText(path, jsonData);
    }

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
