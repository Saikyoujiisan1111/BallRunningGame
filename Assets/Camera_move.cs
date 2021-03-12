using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    GameObject player;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos.z = player.transform.position.z - 2;
        pos.y = player.transform.position.y + 1.7f;
        gameObject.transform.position = pos;
    }
}
