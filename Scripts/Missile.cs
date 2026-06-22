using UnityEngine;

public class Missle : MonoBehaviour
{
    public float speed;
    
    public Missle missle;
    void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    public void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }
    
     











    








































}
