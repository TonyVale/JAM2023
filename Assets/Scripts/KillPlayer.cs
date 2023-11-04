using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{

    bool flag = true;
    public GameObject Cir;
    private Vector3 expand = new Vector3(20,20,-1);
    private Vector3 velocity = new Vector3(10,10,0);
    GameObject Aux;
    
    Transform PlayerTransform;
    // Start is called before the first frame update
    void Awake(){  

    }
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
        if(flag){
            PlayerTransform = GetComponent<Transform>();
            Aux = Instantiate(Cir);
            flag = false;
        }

        GetComponent<Movment>().enabled = false;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        Aux.GetComponent<Transform>().position = transform.position;

        if(expand == new Vector3(0,0,1)){
            Aux.GetComponent<Transform>().localScale =Vector3.SmoothDamp(Aux.GetComponent<Transform>().localScale, expand , ref velocity , 0.2f);
        }else{
            Aux.GetComponent<Transform>().localScale =Vector3.SmoothDamp(Aux.GetComponent<Transform>().localScale, expand , ref velocity , 1f);
        }
        if((int)Aux.GetComponent<Transform>().localScale.x  == (int)expand.x-1 || (int)Aux.GetComponent<Transform>().localScale.x  == (int)expand.x){
            
            if(expand == new Vector3(0,0,1)){
                Destroy(Aux);
                Destroy(gameObject);

            }else{
                
                expand = new Vector3(0,0,1);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                
            }
        }
    }

    

}
