using UnityEngine;

public class Trampoline : MonoBehaviour
{
    
    void OnTriggerEnter(Collider Other)
    {
     Other.GetComponent<Jump>().jumpStrength *= 5;
    }


    void OnTriggerExit(Collider Other)
    {
     Other.GetComponent<Jump>().jumpStrength /= 5;
    }


    
    

















}
