using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UI;
using System.Threading;


public class GameManager : XY_CharacterController
{
    public static GameManager I;


    [SerializeField] private Sprite PlayerJob1;
    [SerializeField] private Sprite PlayerJob2;
    [SerializeField] private RuntimeAnimatorController PlayerAni1;
    [SerializeField] private RuntimeAnimatorController PlayerAni2;
    [SerializeField] private GameObject Player;


    private void Awake()
    {
        I = this;

        int CharacterTypeInt = PlayerPrefs.GetInt("CharacterType");
        switch (CharacterTypeInt)
        {
            case 1:
                CharacterSelect = CharacterType.hero;
                Player.transform.Find("CharacterSprite").GetComponent<SpriteRenderer>().sprite = PlayerJob1;
                Player.transform.Find("CharacterSprite").GetComponent<Animator>().runtimeAnimatorController = PlayerAni1;
                break;
            case 2:
                CharacterSelect = CharacterType.monster;
                Player.transform.Find("CharacterSprite").GetComponent<SpriteRenderer>().sprite = PlayerJob2;
                Player.transform.Find("CharacterSprite").GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
                Player.transform.Find("CharacterSprite").GetComponent<Animator>().runtimeAnimatorController = PlayerAni2;
                Debug.Log(4);
                break;

            default:
                SceneManager.LoadScene("StartScene");
                break;
        }
    }

    public void ChangeCharacter(int number)
    {
        switch (number)
        {
            case 1:
                CharacterSelect = CharacterType.hero;
                Player.transform.Find("CharacterSprite").GetComponent<SpriteRenderer>().sprite = PlayerJob1;
                Player.transform.Find("CharacterSprite").GetComponent<Animator>().runtimeAnimatorController = PlayerAni1;
                break;
            case 2:
                CharacterSelect = CharacterType.monster;
                Player.transform.Find("CharacterSprite").GetComponent<SpriteRenderer>().sprite = PlayerJob2;
                Player.transform.Find("CharacterSprite").GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
                Player.transform.Find("CharacterSprite").GetComponent<Animator>().runtimeAnimatorController = PlayerAni2;
                Debug.Log(4);
                break;

            default:
                SceneManager.LoadScene("StartScene");
                break;
        }
    }

}
