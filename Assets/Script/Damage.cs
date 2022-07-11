using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Damage : Broken
{
    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Hit()
    {
        isDead = true;
        StartCoroutine("Player");
        //Debug.Log("damage");
        //gamemanager.GameOver();
        SceneManager.LoadScene("GameOverScene");
    }
}
