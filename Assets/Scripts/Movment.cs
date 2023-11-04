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
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){

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

        if( !Input.GetKey("d") && rb2d.velocity.x >= 1 ){
            rb2d.AddForce(new Vector2( -2f , 0f ));
        }
        if( !Input.GetKey("a") && rb2d.velocity.x <= -1 ){
            rb2d.AddForce(new Vector2( 2f , 0f ));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "KillPlayer"){
            GetComponent<KillPlayer>().enabled = true ;
        }
    }


}