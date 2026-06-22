using UnityEngine;

public class Coin : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        CoinCounter player = other.GetComponent<CoinCounter>();
        player.CollectCoins();
        Destroy(gameObject);
    }
    
}
