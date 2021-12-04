// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class Player_Controller : MonoBehaviour
{
    public InputField NameInput;


    public void SaveToJson()
    {
        Player_Controller data = new Player_Controller();
        data.NameInput = NameInput.text;

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath+"PlayerDataFile.Json", json);
    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
        Player_Controller data = JsonUtility.FromJson<Player_Controller>(Json);

        NameInput.text = data.NameInput;   
    }
//     public PlayerData playerData;

//     [ContextMenu("To Json Data")]
//     void SavePlayerDataToJson()
//     {
//         string jsonData = JsonUtility.ToJson(playerData, true);
//         string path = Path.Combine(Application.dataPath, "PlayerData.json");
//         File.WriteAllText(path, jsonData);
//     }
//     // [ContextMenu("From Json Data")]
//     // void LoadPlayerDataToJson()
//     // {
//     //     string path = Path.Combine(Application.dataPath, "playerData.json");
//     // }
//     public GameObject Panel;
//     public void OpenPaenl()
//     {
//         if(Panel != null)
//         {
//             bool isActive = Panel.activeSelf;
//             Panel.SetActive(!isActive);
//         }
//     }

//     [System.Serializable]
//     public class PlayerData
//     {
//         public string name;
//         public int age;
//         public int level;
//         public bool isDeed;
//         public string[] items;
//     }
// }
