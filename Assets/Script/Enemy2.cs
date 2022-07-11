using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    private Vector2 pos;
    public int num = 1;

    void Update()
    {
        pos = transform.position;
        transform.Translate(transform.right * Time.deltaTime * 3 * num);

        if(pos.x > 143)
        {
            num = -1;
        }
        if(pos.x < 133)
        {
            num = 1;
        }
    }
}
