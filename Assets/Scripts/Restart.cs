using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SCENE2");
    }
}
