using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackround : MonoBehaviour
{ 
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;
    // Start is called before the first frame update
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        
        groundHorizontalLength = groundCollider.size.x;
    }
   
   
 
    private void RepositionBackground()
    {
    
    Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

    transform.position = (Vector2)transform.position + groundOffSet;
    }


    
     private void Update()
        {
            
            if (transform.position.x < -groundHorizontalLength)
            {
               
                RepositionBackground();
            }
        }
    }

