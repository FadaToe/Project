
using UnityEngine;
using UnityEditor.SceneManagement;
using TMPro;
public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;
    public TextMeshProUGUI timerCounterText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        seconds -= Time.deltaTime;
        

        if (seconds <= 0)
        {
            if (minutes != 0)
            {
                seconds += 59f;
                minutes--;
                print(minutes + " " + seconds);
            }
            else
                //Перезапуск сцены 
                EditorSceneManager.LoadScene(sceneName);
            print("times up");
        }
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerCounterText.text = minutes + ":" + roundSeconds;






    }
}












