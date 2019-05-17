using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    public Text levelTime;
    public float timeCounter;
    public string LeveltoLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = timeCounter - Time.deltaTime;
        levelTime.text = Mathf.RoundToInt(timeCounter).ToString();
        if (timeCounter<0)
        {
            //restart the level
            LoadLevel(LeveltoLoad);
        }
    }


    public void LoadLevel(string  levelName)
    {
       
            SceneManager.LoadScene(levelName);

    }
}
