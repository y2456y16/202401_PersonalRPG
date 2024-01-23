using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterChangeResult : MonoBehaviour
{

    [SerializeField] GameObject CharacterChangeUI;

    public GameManager I;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterChange()
    {
        string strSelection = tag.ToString();
        if (tag == "Character1")
        {
            I.ChangeCharacter(1);
            CharacterChangeUI.SetActive(false);
        }
        else if (tag == "Character2")
        {
            I.ChangeCharacter(2);
            CharacterChangeUI.SetActive(false);
        }
    }
}
