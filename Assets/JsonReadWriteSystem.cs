using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonReadWriteSystem : MonoBehaviour
{
    public InputField NameInputField;
    public platerData data;
    public void SaveToJson()
    {
        LoadFromJson();
        data.Name.Add(NameInputField.text);

        string json = JsonUtility.ToJson(data, true); // 값을 json에 할당.
        
        Debug.Log(Application.dataPath+"/PlayerDataFile.json");
        
        File.WriteAllText(Application.dataPath+"/PlayerDataFile.json", json);
        
        //List<string> Name = items.OrderBy(x => x).Take(10).ToList(); 0 ~ 9 까지의 수 출력
        //List<string> Name = items.OrderBy(x => x).Skip(10).ToList(); 10 ~ 99
        

        //100 명을 입력받았다고 하였을 때, 10명만 제외하고 나머지 90명을 출력해줘야 한다면.
        // data.Name.Add(NameInputFiend.text); -> 전체 입력값.
        // data => 나머지 값. -> data[9] = 10 명의 해당 값. 
        // Debug.Log("그 외" + (result - data[9]) + "함께 하였습니다.");

        int count = default;
        for(int i = 0; i < json.Length; i++)
        {
            if(json[i] < 10)
            {
                count++;
            }
        }  
        Debug.Log("그 외" + count + "명 입니다.");

    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
        data = JsonUtility.FromJson<platerData>(json);

    }
}