using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update

	public GameObject WarpExit;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.tag == "KillPlayer")
       {
      		Destroy(gameObject);
	}
   }

}
