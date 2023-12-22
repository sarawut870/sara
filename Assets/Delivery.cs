using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     [SerializeField] float destroyDelay = 0.5f;
     [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
     [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
     bool hasPackage;    
     //255,224,0
     
     SpriteRenderer spriteRenderer;

     void Start()
     {
          spriteRenderer = GetComponent<SpriteRenderer>();
     }
   void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("HOLY SHIT!!!!!!");
   }

   void OnTriggerEnter2D(Collider2D other) 
   {
        if (other.tag == "Package" && !hasPackage)
        {
          Debug.Log("ได้ของแล้ว");
          hasPackage = true;
          spriteRenderer.color = hasPackageColor;
          Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Custonmer" && hasPackage)
        {
          Debug.Log("ชนคนแล้ว");
          hasPackage = false;
          spriteRenderer.color = noPackageColor;
        }
   }

}