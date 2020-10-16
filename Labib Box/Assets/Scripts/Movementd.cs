using UnityEngine;

public class Movementd : MonoBehaviour
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

        if (Input.GetKey("5"))
        {
            rb.AddForce(0, Jumpforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }


    }
}