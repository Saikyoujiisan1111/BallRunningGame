using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalmasu : MonoBehaviour
{
    public float gmasu;
    public bool goalhantei = false;
    public GameObject player;
    player_move pm;
    // Start is called before the first frame update
    void Start()
    {
        gmasu = gameObject.transform.position.z;
        pm = player.GetComponent<player_move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision ataru)
    {
        if(ataru.gameObject.name == "player")
        {
            goalhantei = true;
            pm.owari = false;
        }
    }
}
