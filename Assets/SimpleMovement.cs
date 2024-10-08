using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed;
    private float move;
    private float uppies;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal") * speed;
        uppies = Input.GetAxisRaw("Vertical") * speed;
        rb.velocity = new Vector2(move, uppies);

        //rb.velocity = new Vector2(move * speed, rb.velocity.y);
        //rb.velocity = new Vector2(uppies * speed, rb.velocity.x);
    }
}
