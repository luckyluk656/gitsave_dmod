using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class SaveFile : MonoBehaviour
{
    string saveFile;
    GameData gameData = new GameData();
    public GameState gs;



    void Awake()
    {
        saveFile = Application.persistentDataPath + "/gameData.json";
        Debug.Log($"Savefile path: {saveFile}");
    }

    public void WriteFile()
    {
        gameData = gs.ToGameData();
        string jsonString = JsonUtility.ToJson( gameData );
        File.WriteAllText(saveFile, jsonString );
    }
    public void ReadFile()
    {
        if (File.Exists(saveFile))
        {
            string fileContent = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameData>(fileContent);
            gs.LoadGameData(gameData);
        }
        else
        {
            Debug.Log($"Error: No file found: {saveFile}");
        }
    }
}
