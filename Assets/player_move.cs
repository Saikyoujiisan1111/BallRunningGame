using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    Rigidbody rb;
    bool isJunp = true;
    public int speed = 1;
    //int velK = 0;
    Vector3 vel;
    public bool grounded = false;
    float start;
    public bool gameover = false;
    float finish;
    public float score = 0;
    goalmasu gm;
    public GameObject Gy;
    public bool owari = false; //スコアを表示させる時に使う。trueにする　＝　表示！
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = gameObject.transform.position.z;
        gm = Gy.GetComponent<goalmasu>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;
        pos = rb.position;
        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward * 3).x;
        rb.MovePosition(pos);
        vel = rb.velocity;
        vel.z = 3;
        if (grounded == true)
        {
            for (int i = speed; i > 1; i--)
            {
                vel.z *= 2;
            }
        }

        if (isJunp == true)
        {
            vel.z = 3;
            vel.y = 13;
            isJunp = false;
        }
        rb.velocity = vel;
        if (gameObject.transform.position.y < -10)
        {
            gameover = true;
        }
        if (gameover == true)
        {
            finish = gameObject.transform.position.z;
            finish -= start;
            gm.gmasu -= start;
            score = (finish / gm.gmasu );
            if (gm.goalhantei == true)
            {
                score = 1;
            }
            owari = true;
            button.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    public void Junp()
    {
        isJunp = true;
    }
    public void Speedup()
    {
        speed += 1;
    }
    /*public void OnTriggerEnter(Collider fureru)
    {
        if (fureru.gameObject.tag == "ground")
        {
            grounded = true;
        }
    }
    public void OnTriggerExit(Collider ha)
    {
        if(ha.gameObject.tag == "ground")
        {
            grounded = false;
        }
    }*/
}
