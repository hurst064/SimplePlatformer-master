using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthControll : MonoBehaviour
{
    public int health;
    public string leveltoload;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //gameObject.transform.parent.gameObject.SetActive(false);
            SceneManager.LoadScene(leveltoload);
        }
    }
    public void TakeDamage(int damage)
    {
        health = health - damage;
    }
}
