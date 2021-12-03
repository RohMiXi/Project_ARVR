using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



[System.Serializable]
public class Data
{
    public int m_nLevel;
    public Vector3 m_vecPosition;
    public void printData()
    {
        Debug.Log("Recent People number : " + m_nLevel);
        Debug.Log("Position : " + m_vecPosition);
    }
}
public class Json_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Data data = new Data();
        data.m_nLevel = 12;
        data.m_vecPosition = new Vector3(3.4f, 5.6f, 7.8f);

        string str = JsonUtility.ToJson(data);
        Debug.Log("ToJson" + str);


        Data data2 = JsonUtility.FromJson<Data>(str);
        data2.printData();

        Data data3 = new Data();
        data3.m_nLevel = 99;
        data3.m_vecPosition = new Vector3(8.1f, 9.2f, 7.2f);

        File.WriteAllText(Application.dataPath + "/TestJson.json", JsonUtility.ToJson(data3));


        string str2 = File.ReadAllText(Application.dataPath + "/TestJson.json");

        Data data4 = JsonUtility.FromJson<Data>(str2);
        data4.printData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
