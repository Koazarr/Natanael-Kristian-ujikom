using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 2f;
   public float minx = -2f;
   public float maxx = 2f;

   void update (){
    float moveHorizontal = Input.GetAxis("Horizontal");
    
    Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * moveSpeed * Time.deltaTime;
    
    transform.Translate(movement);
    
    float clampedX = Mathf.Clamp(transform.position.x,minx,maxx);
    
    transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
   }
}
