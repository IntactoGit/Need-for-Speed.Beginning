using System;
using UnityEngine;

public class Car : MonoBehaviour
{
  [SerializeField]
   private float _speed;

   private void Update()
   {
       var position = gameObject.transform.position;
       var step = _speed * Time.deltaTime;

       if (Input.GetKey(KeyCode.D))
       {
           position.x += step;
       }
       else if (Input.GetKey(KeyCode.A))
       {
           position.x -= step; 
       }
       else if (Input.GetKey(KeyCode.W))
       {
           position.z += step; 
       }
       else if (Input.GetKey(KeyCode.S))
       {
           position.z -= step; 
       }
       
       transform.position = position;

   }
   
   
   
   
   
   
   
   
   
   
   
   
}
