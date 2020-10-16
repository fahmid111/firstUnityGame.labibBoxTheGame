using UnityEngine;

public class Move3 : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sforce = 500f;
    public float Jumpforce = 5f;

   
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, Jumpforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }


    }
}
