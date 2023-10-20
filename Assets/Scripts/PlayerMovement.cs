using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // We marked "Fixed"Update because we are usint it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Add a forward force

        if(Input.GetKey("d"))
        {
            //Only excecuted if the condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            //Only excecuted if the condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
