<<<<<<< HEAD
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
=======
using System;
>>>>>>> 6bfd4af (Player Fatures V1.0)
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
<<<<<<< HEAD
>>>>>>> 04d7f84 (movment first commi)
=======
    public int MaxFloorHeight;
    public int MaxJumpVelocity;
    public GameObject DownCollitionRadar;
    public GameObject Water;

    RaycastHit2D _hit;
>>>>>>> 6bfd4af (Player Fatures V1.0)
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
        trans = GetComponent<Transform>();
        DownCollitionRadarTrans = DownCollitionRadar.GetComponent<Transform>();
        
    }
    
    // Start is called before the first frame update
    void Start(){

    }

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
<<<<<<< HEAD
=======
>>>>>>> 6bfd4af (Player Fatures V1.0)
        if(Input.GetKey("space") && _hit.distance <= MaxFloorHeight && watherCharge >= 0 && rb2d.velocity.y <= MaxJumpVelocity ){
            
            Instantiate(Water, DownCollitionRadarTrans);
            rb2d.AddForce(new Vector2( 0f , watherPower ));
<<<<<<< HEAD
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
=======
>>>>>>> 6bfd4af (Player Fatures V1.0)
            watherCharge--;
            //Draw2DRay(trans.position, Vector2.down * _hit.distance);
        }
        Debug.Log(_hit.collider.name);
        Debug.Log(_hit.distance);

    }

    void Update(){
<<<<<<< HEAD
>>>>>>> 04d7f84 (movment first commi)
=======

        
        _hit = Physics2D.Raycast(DownCollitionRadarTrans.position, Vector2.down);

>>>>>>> 6bfd4af (Player Fatures V1.0)
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