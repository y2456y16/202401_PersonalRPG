using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.SceneManagement;

public class MainCameraObjectController : MonoBehaviour
{


    public GameObject Player;

    public float setX = 0.0f;
    public float setY = 0.0f;
    public float setZ = -10.0f;

    public float cameraSpeed = 5.0f;

    Vector3 PlayerPos;
    

    private void Update()
    {
        PlayerPos = new Vector3(
            Player.transform.position.x + setX,
            Player.transform.position.y + setY,
            Player.transform.position.z + setZ);

        transform.position = Vector3.Lerp(transform.position, PlayerPos, Time.deltaTime*cameraSpeed);
    }
}
