using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMovement : MonoBehaviour
{
    public float speed;
    public bool moveRight;

    SpriteRenderer spriteRender;
    

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>(); 
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float xScale = transform.localScale.x;
        float yScale = transform.localScale.y;
        float zScale = transform.localScale.z;

        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            float negative = -Mathf.Abs(xScale);
            transform.localScale = new Vector3(negative, yScale, zScale);

            //transform.localScale = new Vector2(-xScale, yScale);

        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            float positive = Mathf.Abs(xScale);
            transform.localScale = new Vector3(positive, yScale, zScale);
            
            //transform.localScale = new Vector2(xScale, yScale);
        }
    }

    void OnCollisionEnter2D (Collision2D col)
    {
       if (col.gameObject.tag == "door")
       {
           Destroy(this.gameObject);
       }
    }
}
