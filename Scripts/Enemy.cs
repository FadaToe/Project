using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //–азворачивает каждый кадр NPC лицом к цели

        transform.LookAt(target.position);
    }
     void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Health>().TakeDamage(playerDamage);
        
        
      
        

    }




    
















}
