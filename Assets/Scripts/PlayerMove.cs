using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float ForwardForce = 1000f;
    public float SideForce = 150f;
    public Rigidbody rb;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("a"))
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rb.position.y < 1F)
            FindObjectOfType<GameManager>().EndGame();
        if (Input.GetKey("space"))
        {
            rb.AddForce(0 , 0, ForwardForce * Time.deltaTime * 0.05f, ForceMode.VelocityChange);
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        }
    }
}
