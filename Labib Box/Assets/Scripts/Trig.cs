using UnityEngine;

public class Trig : MonoBehaviour
{
    public GameManager gm;

    void OnTriggerEnter()
    {
        gm.Complete();
    }
}
