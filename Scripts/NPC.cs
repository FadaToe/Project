using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 3;
    public int level = 2;
    public float speed = 4.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = health + level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
