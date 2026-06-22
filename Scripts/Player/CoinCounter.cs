using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public int coin;
    public AudioClip coinClaim;
    public AudioSource audioSourse;
    public void CollectCoins()
    {
        coin++;
        print(coin);
        audioSourse.PlayOneShot(coinClaim);



    }



































}
