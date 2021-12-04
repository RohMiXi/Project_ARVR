// using System.Collections;
// using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonReadWriteSystem : MonoBehaviour
{
    public InputField NameInputField;


    public void SaveToJson()
    {
        platerData data = new platerData();
        data.Name = NameInputField.text;
       

        string json = JsonUtility.ToJson(data, true);
        
        Debug.Log(Application.dataPath+"/PlayerDataFile.json");
        
        File.WriteAllText(Application.dataPath+"/PlayerDataFile.json", json);

    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
        platerData data = JsonUtility.FromJson<platerData>(json);

        NameInputField.text = data.Name;   
    }
}