using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    private Health health;
    private CoinCounter coincounter;
    public Slider healthSlider;
    public TextMeshProUGUI coinCounterText;
    // Update is called once per frame
    void Awake()
    {
        health = GetComponent<Health>();
        coincounter = GetComponent<CoinCounter>();
    }
    void Update()
    {
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;
        coinCounterText.text = coincounter.coin.ToString();
    }
}
