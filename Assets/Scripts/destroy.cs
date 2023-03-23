using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject destroyedVersion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("blue"))
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    
}
}
