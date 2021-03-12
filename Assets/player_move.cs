using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    Rigidbody rb;
    bool isJunp = true;
    public int speed = 1;
    int velK = 0;
    Vector3 vel;
    public bool grounded = false;
    Vector3 start;
    public bool gameover = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        start = gameObject.transform.position;
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
                Debug.Log("hoge2");
            }
        }

        if (isJunp == true)
        {
            vel.z = 3;
            vel.y = 13;
            isJunp = false;
        }
        Debug.Log(vel.z);
        rb.velocity = vel;
        if ()
        {
            
        }
    }
    public void Junp()
    {
        isJunp = true;
    }
    public void Speedup()
    {
        speed += 1;
        Debug.Log("hoge1");
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
