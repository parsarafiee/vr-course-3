using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    Rigidbody rb;
    Player player;
    public float speed;
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = (player.transform.position - this.transform.position) * speed*Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
