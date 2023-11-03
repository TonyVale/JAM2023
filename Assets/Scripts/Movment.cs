<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

//2 CHESS, 2 BOND, 2 ROQUE 
public class Movment : MonoBehaviour
{

    Rigidbody2D rb2d;
    Transform DownCollitionRadarTrans;

    public int watherCharge;
    public int watherPower; 
    public int MaxFloorHeight;
    public int MaxJumpVelocity;
    public GameObject DownCollitionRadar;
    public GameObject Water;
    

    RaycastHit2D _hit;
=======
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
>>>>>>> 04d7f84 (movment first commi)
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
<<<<<<< HEAD

        rb2d = GetComponent<Rigidbody2D>();
        DownCollitionRadarTrans = DownCollitionRadar.GetComponent<Transform>();
        
    }
    
    // Start is called before the first frame update
    void Start(){

    }

    void FixedUpdate(){

        //movment


        if(Input.GetKeyDown("d") && rb2d.velocity.x < 6){
            rb2d.AddForce(new Vector2( 100f , 0f ));
        }
        if(Input.GetKeyDown("a") && rb2d.velocity.x > -6){
            rb2d.AddForce(new Vector2( -100f , 0f ));
        }
=======
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

>>>>>>> 04d7f84 (movment first commi)
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

<<<<<<< HEAD
        if(Input.GetKey("space") && _hit.distance <= MaxFloorHeight && watherCharge >= 0 && rb2d.velocity.y <= MaxJumpVelocity ){
            
            Instantiate(Water, DownCollitionRadarTrans);
            rb2d.AddForce(new Vector2( 0f , watherPower ));
            watherCharge--;
            
        }

        if(Input.GetKey("r")){
            GetComponent<KillPlayer>().enabled = true;
        }

    }

    

    void Update(){

        
        _hit = Physics2D.Raycast(DownCollitionRadarTrans.position, Vector2.down);

=======
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
>>>>>>> 04d7f84 (movment first commi)
        if( !Input.GetKey("d") && rb2d.velocity.x >= 1 ){
            rb2d.AddForce(new Vector2( -2f , 0f ));
        }
        if( !Input.GetKey("a") && rb2d.velocity.x <= -1 ){
            rb2d.AddForce(new Vector2( 2f , 0f ));
        }
    }
<<<<<<< HEAD

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "KillPlayer"){
            GetComponent<KillPlayer>().enabled = true ;
        }
    }


=======
>>>>>>> 04d7f84 (movment first commi)
}