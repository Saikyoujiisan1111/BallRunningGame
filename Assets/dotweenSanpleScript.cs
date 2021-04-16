using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class dotweenSanpleScript : MonoBehaviour
{
    player_move pm;
    GameObject player;
    public GameObject score;
    Text paaa;
    public int Tscore;
    public int TTscore = 0;
    public float Fscore;
    // Start is called before the first frame update
    void Start()
    {
        score.SetActive(false);
        player = GameObject.Find("player");
        pm = player.GetComponent<player_move>();
        paaa = score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        paaa.text = TTscore.ToString() + "%";
        if (TTscore == Tscore)
        {
            CancelInvoke();
        }
        if (pm.owari == true)
        {
            gameObject.GetComponent<Image>().DOFillAmount(pm.score, 2);
            Fscore = pm.score * 100;
            Tscore = (int)(pm.score * 100);
            score.SetActive(true);
            InvokeRepeating("Fuyasu", 0, 2 / Fscore);
            pm.owari = false;
        }
    }
    void Fuyasu()
    {
        TTscore++;
    }
}

