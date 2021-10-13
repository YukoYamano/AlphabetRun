using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rBody;

    public float speed = 2.0f;
    public float jumpForce = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rBody.velocity = rBody.velocity.normalized * speed;

        rBody.velocity = new Vector2(speed,rBody.velocity.y);
       
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rBody.velocity = new Vector2(rBody.velocity.x, jumpForce);
        }
    }
}
