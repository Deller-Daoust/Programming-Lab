using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_System : MonoBehaviour
{
    private Player_Combat p_combat;

    [SerializeField] private ScoreData _Score = new ScoreData();

    void Start()
    {
        p_combat = gameObject.GetComponent<Player_Combat>();

        InvokeRepeating("SaveAsJson", 2, 1);
    }

    void Update()
    {
        _Score.score = p_combat.score;
    }

    public void SaveAsJson()
    {
        string scoreStr = JsonUtility.ToJson(_Score);
        System.IO.File.WriteAllText(Application.dataPath + "/ScoreData.json", scoreStr);
    }
}

[System.Serializable]
public class ScoreData
{
    public int score;
}
