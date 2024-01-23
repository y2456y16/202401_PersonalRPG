using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XY_CharacterName : XY_CharacterController
{
    public Text CharacterName;

    private void Awake()
    {
        LoadNameData();
    }
    void Start()
    {
        
    }


    void LoadNameData()//get name text from data(saved by StartScene)
    {
        CharacterName.text = PlayerPrefs.GetString("Name");
    }
}
