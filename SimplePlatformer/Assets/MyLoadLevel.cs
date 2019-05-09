using UnityEngine;
using UnityEngine.SceneManagement;

public class MyLoadLevel : MonoBehaviour
{
    public string LevelToLoad;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
