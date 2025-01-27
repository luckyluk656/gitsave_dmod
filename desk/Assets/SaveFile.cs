using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SaveFile : MonoBehaviour
{
    string saveFile;
    GameData gameData = new GameData();



    void Awake()
    {
        saveFile = Application.persistentDataPath + "/gameData.json";
        Debug.Log($"Savefile path: {saveFile}");
    }

    public void WriteFile()
    {
        string jsonString = JsonUtility.ToJson( gameData );
        File.WriteAllText(saveFile, jsonString );
    }
}
