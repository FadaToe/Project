using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    public float speedFactor = 2.5f;
    void OnTriggerEnter(Collider other)
    {
     other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
    }
    void OnTriggerExit(Collider other)
    {
    other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }
        
    

    
    
    
        
    
}
