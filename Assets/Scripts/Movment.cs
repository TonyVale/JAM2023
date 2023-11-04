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
    Transform trans;
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
        trans = GetComponent<Transform>();
        DownCollitionRadarTrans = DownCollitionRadar.GetComponent<Transform>();
        
    }
    
    // Start is called before the first frame update
    void Start(){

    }

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

        if(Input.GetKey("space") && _hit.distance <= MaxFloorHeight && watherCharge >= 0 && rb2d.velocity.y <= MaxJumpVelocity ){
            
            Instantiate(Water, DownCollitionRadarTrans);
            rb2d.AddForce(new Vector2( 0f , watherPower ));
            watherCharge--;
            //Draw2DRay(trans.position, Vector2.down * _hit.distance);
        }
        Debug.Log(_hit.distance);

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
}