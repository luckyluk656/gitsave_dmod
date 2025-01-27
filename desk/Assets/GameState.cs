using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int XP;
    public string PlayerName;
    public List<string> Inventar;

    public void LoadGameData(GameData gameData)
    {
        XP = gameData.XP;
        PlayerName = gameData.PlayerName;
        Inventar = gameData.Inventar;
    }
    public GameData ToGameData()
    {
        GameData gameData = new GameData();
        gameData.XP = XP;
        gameData.PlayerName = PlayerName;
        gameData.Inventar = Inventar;
        return gameData;
    }
}
