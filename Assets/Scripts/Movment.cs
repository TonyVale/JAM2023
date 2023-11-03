using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public GameObject Floor;
    Rigidbody2D rb2d;

    public int watherCharge;
    public int watherPower; 
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
        rb2d = GetComponent<Rigidbody2D>();

    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    /// <summary>
    
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate(){

        if(Input.GetKey("d")){            
            rb2d.AddForce(new Vector2( 10f , 0f ));
            if(rb2d.velocity.x > 6 ){
                rb2d.AddForce(new Vector2( -10f , 0f ));
            }
        }

        if(Input.GetKey("a")){
            rb2d.AddForce(new Vector2( -10f , 0f ));
            if(rb2d.velocity.x < -6 ){
                rb2d.AddForce(new Vector2( 10f , 0f ));
            }
        }

        if(Input.GetKey("space") && watherCharge >= 0 && Mathf.Abs(GetComponent<Transform>().position.y - Floor.GetComponent<Transform>().position.y) <= 5 ){
            rb2d.AddForce(new Vector2( 0f , watherPower));
            watherCharge--;
            Debug.Log("Go");
            if(rb2d.velocity.y > 4 ){
                Debug.Log("Back");
                rb2d.AddForce(new Vector2( 0f , -watherPower ));
            }
        }
        if(Input.GetKey("space") && watherCharge >= 0 && Mathf.Abs(GetComponent<Transform>().position.y - Floor.GetComponent<Transform>().position.y) >= 5){
            watherCharge--;
        }


    }

    void Update(){
        if( !Input.GetKey("d") && rb2d.velocity.x >= 1 ){
            rb2d.AddForce(new Vector2( -2f , 0f ));
        }
        if( !Input.GetKey("a") && rb2d.velocity.x <= -1 ){
            rb2d.AddForce(new Vector2( 2f , 0f ));
        }
    }
}