﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0, 0);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
       if (col.gameObject.tag == "door")
       {
           Destroy(this.gameObject);
       }
    }
}
