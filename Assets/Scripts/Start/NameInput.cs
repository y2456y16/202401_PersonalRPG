using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{

    [SerializeField] private InputField InputName;
    public Button Button_Complete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickJoin()
    {
        if(!(2< InputName.text.Length && InputName.text.Length <10))
        {
            return;
        }
        else
        {
            SaveData();
            SceneManager.LoadScene("MainScene");
        }
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("Name", InputName.text);
    }
}
