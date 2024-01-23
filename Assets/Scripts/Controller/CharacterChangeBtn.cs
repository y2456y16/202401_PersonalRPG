using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChangeBtn : MonoBehaviour
{

    [SerializeField] private GameObject CharacterCUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterChangeUI()
    {
        CharacterCUI.SetActive(true);
    }
}
