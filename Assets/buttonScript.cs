using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    player_move pm;
    GameObject player;
    buttonScript bs;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        /*player = GameObject.Find("player");
        pm = player.GetComponent<player_move>();
        bs = gameObject.GetComponent<buttonScript>();*/
    }

    // Update is called once per frame
    void Update()
    {
        /*if (pm.owari == true)
        {
            bs.enabled = true;
        }*/
    }
    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
