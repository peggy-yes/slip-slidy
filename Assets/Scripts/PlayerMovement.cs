using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb".

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardsForce = 500f;

    // We marked this as "FixedUpdate" because we are using it to mess with physics.
    void FixedUpdate ()
    {

        rb.AddForce(0, 3, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
  
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
      
        if(rb.position.y < -3f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }


}

