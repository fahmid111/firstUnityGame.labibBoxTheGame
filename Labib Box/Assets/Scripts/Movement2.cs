using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public Rigidbody rb;
    public Transform player;
    public Vector3 rotate;
    public float sforce = 50f;

    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * 15 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * 15 * Time.deltaTime);
        }
        if (Input.GetKey("5"))
        {
            rb.AddForce(0, sforce * Time.deltaTime,0, ForceMode.VelocityChange);
        }

        if (rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }


    }
}
