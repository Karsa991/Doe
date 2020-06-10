using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed=2f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //GetAxisRaw gt thelw i times na einai akrivos(-1,-0,1)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    //fixed
    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed *Time.fixedDeltaTime);      
    }
}
