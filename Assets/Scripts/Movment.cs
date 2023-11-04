<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> cfdac43 (Player Fatures V1.0)
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
<<<<<<< HEAD
<<<<<<< HEAD
=======
    Transform trans;
>>>>>>> cfdac43 (Player Fatures V1.0)
    Transform DownCollitionRadarTrans;

    public int watherCharge;
    public int watherPower; 
    public int MaxFloorHeight;
    public int MaxJumpVelocity;
    public GameObject DownCollitionRadar;
    public GameObject Water;
<<<<<<< HEAD
    

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
=======
>>>>>>> 0b14882 (Player Finish)
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
=======

    RaycastHit2D _hit;
>>>>>>> cfdac43 (Player Fatures V1.0)
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

        rb2d = GetComponent<Rigidbody2D>();
=======
        rb2d = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
>>>>>>> cfdac43 (Player Fatures V1.0)
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
=======

>>>>>>> 0b14882 (Player Finish)
        rb2d = GetComponent<Rigidbody2D>();
        DownCollitionRadarTrans = DownCollitionRadar.GetComponent<Transform>();
        
    }
    
    // Start is called before the first frame update
    void Start(){

    }

    void FixedUpdate(){

<<<<<<< HEAD
>>>>>>> 04d7f84 (movment first commi)
=======
        //movment


        if(Input.GetKeyDown("d") && rb2d.velocity.x < 6){
            rb2d.AddForce(new Vector2( 100f , 0f ));
        }
        if(Input.GetKeyDown("a") && rb2d.velocity.x > -6){
            rb2d.AddForce(new Vector2( -100f , 0f ));
        }
>>>>>>> 0b14882 (Player Finish)
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
<<<<<<< HEAD
=======
>>>>>>> 6bfd4af (Player Fatures V1.0)
=======
>>>>>>> cfdac43 (Player Fatures V1.0)
        if(Input.GetKey("space") && _hit.distance <= MaxFloorHeight && watherCharge >= 0 && rb2d.velocity.y <= MaxJumpVelocity ){
            
            Instantiate(Water, DownCollitionRadarTrans);
            rb2d.AddForce(new Vector2( 0f , watherPower ));
<<<<<<< HEAD
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
=======
>>>>>>> cfdac43 (Player Fatures V1.0)
            watherCharge--;
            
        }

        if(Input.GetKey("r")){
            GetComponent<KillPlayer>().enabled = true;
        }

    }

    

    void Update(){
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 04d7f84 (movment first commi)
=======
=======
>>>>>>> cfdac43 (Player Fatures V1.0)

        
        _hit = Physics2D.Raycast(DownCollitionRadarTrans.position, Vector2.down);

<<<<<<< HEAD
>>>>>>> 6bfd4af (Player Fatures V1.0)
=======
>>>>>>> cfdac43 (Player Fatures V1.0)
        if( !Input.GetKey("d") && rb2d.velocity.x >= 1 ){
            rb2d.AddForce(new Vector2( -2f , 0f ));
        }
        if( !Input.GetKey("a") && rb2d.velocity.x <= -1 ){
            rb2d.AddForce(new Vector2( 2f , 0f ));
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 0b14882 (Player Finish)

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "KillPlayer"){
            GetComponent<KillPlayer>().enabled = true ;
        }
    }


<<<<<<< HEAD
=======
>>>>>>> 04d7f84 (movment first commi)
=======
>>>>>>> 0b14882 (Player Finish)
}