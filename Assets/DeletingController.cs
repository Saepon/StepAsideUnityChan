using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
       void OnBecameInvisible()
        {
         GameObject.Destroy(this.gameObject);
         }
    // Update is called once per frame
    void Update()
    {
 
    }
}
