using UnityEngine;

public class Controll2 : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    public Rigidbody rb;

    public float rotationRate = 360;
    public float moveSpeed = 2;
    void Update()
    {
        
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        ApplyInput(moveAxis, turnAxis);
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }
    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
    }
    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
