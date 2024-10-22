using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 7f;
    private float move;
    private float uppies;
        
    private Rigidbody2D rb;

    bool facingRight = true;

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

        if (move > 0 && !facingRight){
             Flip();
        }

        if (move < 0 && facingRight){
             Flip();
        }
    }

    void Flip(){
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
