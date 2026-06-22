using UnityEngine;
using UnityEditor.SceneManagement;
public class Smert : MonoBehaviour
{
    public string sceneName;
    void OnTriggerEnter(Collider Other)
    {
       
        
            EditorSceneManager.LoadScene(sceneName);
       
       
    }
}
