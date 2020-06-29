using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingController : MonoBehaviour
{
    private GameObject MainCamera;
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        this.MainCamera = GameObject.Find("Main Camera");
        

    }
     
    // Update is called once per frame
    void Update()
    {        this.difference = this.transform.position.z -MainCamera.transform.position.z ;

   if (this. difference < -1)
        {
         GameObject.Destroy(this.gameObject);
         }
    }
}
