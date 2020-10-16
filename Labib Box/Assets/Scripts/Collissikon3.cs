using UnityEngine;

public class Collissikon3 : MonoBehaviour
{
    public Move3 movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
