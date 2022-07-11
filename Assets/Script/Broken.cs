using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Broken : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Hit(); 
            Destroy(gameObject, 0.2f);
        }
    }

    public abstract void Hit();
}
