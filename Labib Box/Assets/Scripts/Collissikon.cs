using UnityEngine;

public class Collissikon : MonoBehaviour
{
    public Movementd movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
