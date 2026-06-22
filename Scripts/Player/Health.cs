using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    public AudioClip damageSound;
    public AudioSource audioSourse;
    public int health = 10;
    public int maxHealth = 10;
    public void TakeDamage(int damage)
    {
        health = health - damage;
        if (health > 0)
        {
            audioSourse.PlayOneShot(damageSound);
            print("Здоровье игрока:" + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

    }





















}
