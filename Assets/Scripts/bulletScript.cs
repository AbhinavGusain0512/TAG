using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public float life = 6;
    public GameObject destroyedVersion;
    


    private void Awake()
    {
        Destroy(gameObject, life);

    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer !=6  && !collision.gameObject.CompareTag("Player") )
        {
            if (gameObject.CompareTag("bullR"))
            {
                Instantiate(destroyedVersion, transform.position, transform.rotation);
                Destroy(collision.gameObject);
                
                
            }
            if (gameObject.CompareTag("bullL"))
            {
                Destroy(collision.gameObject);
                
                Debug.Log(collision.gameObject);
                
            }


                
            
        }
        
        Destroy(gameObject);
    }
}
