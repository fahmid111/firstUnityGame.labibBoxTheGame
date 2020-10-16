using UnityEngine;

public class Collissikon2 : MonoBehaviour
{
    public Controll2 movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
