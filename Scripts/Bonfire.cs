using UnityEngine;
public class Bonfire : MonoBehaviour
{
    public float lifeTime = 15;
    public float heatPower = 0.1f;

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Tempereture>() != null)
        {
            Tempereture temperature = other.GetComponent<Tempereture>();

            if (temperature.temper < temperature.nachalTempereture);
            {
                temperature.temper += heatPower * Time.deltaTime;
            }
        }
    }
}
