using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public GameObject ChooseCharacterUI;
    public GameObject InputNameUI;
    public GameObject Character1;
    public GameObject Character2;


    public int selection = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LayerSet()
    {
        
    }

    public void CharacterSelection()
    {
        string strSelection = tag.ToString();
        if (tag == "Character1")
        {
            selection = 1;
            Character1.GetComponent<Button>().enabled = false;
            float betweenX = (-1) * (Character1.transform.position.x - Character1.transform.position.x);
            Character1.GetComponent<Transform>().position += new Vector3(betweenX,0,0);
            Character2.SetActive(false);
            ChooseCharacterUI.SetActive(false);
            InputNameUI.SetActive(true);
            SaveData(selection);
        }
        else if(tag == "Character2")
        {
            selection = 2;
            Character1.SetActive(false);
            Character2.GetComponent<Button>().enabled = false;
            float betweenX = (-1)*(Character2.transform.position.x - Character1.transform.position.x);
            Character2.GetComponent<Transform>().position += new Vector3(betweenX, 0, 0);
            ChooseCharacterUI.SetActive(false);
            InputNameUI.SetActive(true);
            SaveData(selection);
        }
        else
        {
            SceneManager.LoadScene("StartScene");
        }
        
    }



    public void SaveData(int number)
    {
        PlayerPrefs.SetInt("CharacterType", number);
    }
}
