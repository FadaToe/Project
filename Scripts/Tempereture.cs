using UnityEngine;

public class Tempereture : MonoBehaviour
{
    public float nachalTempereture = 36.6f;
    public float kriticTempereture = 34f;
    public float temper = 36.6f;
    public int damagekriticTemper = 1;
    public float freezSpeed = 0.5f;
    private Health health;
    public float freezDamageTimer = 1;
    public float freezDamageDelay = 2;

    void Awake()
    {
        health = GetComponent<Health>();
    }
    void Update()
    {
        temper -= freezSpeed * Time.deltaTime;

        if (temper <= kriticTempereture)
        {
            if (freezDamageTimer <= 0)
            {
                health.TakeDamage(damagekriticTemper);
                freezDamageTimer += freezDamageDelay;
            }
            else
            {
                freezDamageTimer -= Time.deltaTime;
            }

        }

    }















}
