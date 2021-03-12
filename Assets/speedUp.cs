using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    public GameObject player;
    player_move pm;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        pm = player.GetComponent<player_move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider fumu)
    {
        if(fumu.gameObject.name == "pp")
        {
            pm.Speedup();
            Debug.Log("hoge");
        }
    }
}
