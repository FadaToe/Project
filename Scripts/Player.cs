//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Player : MonoBehaviour
//{
//    public AudioClip coinClaim;
//    public AudioSource audioSourse;
//    public AudioClip damageSound;
//    public int Health = 10;
//    public int maxHealth = 10;
//    public GameObject fireballPrefab;
//    public Transform attackPoint;
//    public int coin;

//    public void TakeDamage(int damage)
//    {
//        Health = Health - damage;
//        if (Health > 0)
//        {
//            audioSourse.PlayOneShot(damageSound);
//            print("Здоровье игрока:"+ Health);
//        }
//        else
//        {
//            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
//            SceneManager.LoadScene(sceneIndex);
//        }

//    }
//    public void Update()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);



//        }
//    }
//    public void CollectCoins()
//    {
//        coin++;
//        print(coin);
//        audioSourse.PlayOneShot(coinClaim);



//    }





















//}
