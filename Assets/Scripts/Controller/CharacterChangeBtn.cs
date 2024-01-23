using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChangeBtn : MonoBehaviour
{

    [SerializeField] private GameObject CharacterCUI;
 
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void CharacterChangeUI()//MainScene Character btn click : UI pops up
    {
        CharacterCUI.SetActive(true);
    }
}
