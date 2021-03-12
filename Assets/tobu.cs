using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tobu : MonoBehaviour
{
     player_move player;
    // Start is called before the first frame update
    void Start()
    { 
        player = GameObject.Find("player").GetComponent<player_move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision noru)
    {
        player.Junp();
    }
}
