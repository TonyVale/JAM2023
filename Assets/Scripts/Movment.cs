using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//2 CHESS, 2 BOND, 2 ROQUE 
public class Movment : MonoBehaviour
{
    
    Rigidbody2D rb2d;
    Transform DownCollitionRadarTrans;

    public float watherCharge;
    private float TotalWatherCharge;
    public int watherPower; 
    public int MaxFloorHeight;
    public int MaxJumpVelocity;
    public GameObject DownCollitionRadar;
    public GameObject Water;
    private GameObject ChargeBar;

    private Animator anim; 
    


    RaycastHit2D _hit;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
        anim = GetComponent<Animator>(); 
        ChargeBar = UnityEngine.GameObject.FindGameObjectsWithTag("ChargeBar")[0];
        watherCharge = SceneManager.GetActiveScene().buildIndex * 100 ;
        TotalWatherCharge = watherCharge;
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
            anim.SetBool(anim.GetParameter(1).name, true);
            Instantiate(Water, DownCollitionRadarTrans);
            rb2d.AddForce(new Vector2( 0f , watherPower ));
            watherCharge--;
        }

        if(Input.GetKey("r")){
            GetComponent<KillPlayer>().enabled = true;
        }

        ChargeBar.GetComponent<UnityEngine.UI.Image>().fillAmount = watherCharge/TotalWatherCharge;

    }

    

    void Update(){
        

        if(Input.GetKey(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }

        _hit = Physics2D.Raycast(DownCollitionRadarTrans.position, Vector2.down);
        if(Input.GetKeyDown("d")){
            anim.SetBool(anim.GetParameter(0).name, true);
            gameObject.GetComponent<Transform>().eulerAngles = new Vector3(0,0,0);
        }
        if(Input.GetKeyDown("a")){
            anim.SetBool(anim.GetParameter(0).name, true);
            gameObject.GetComponent<Transform>().eulerAngles = new Vector3(0,180,0);
        }
        if(Input.GetKeyUp("a") || Input.GetKeyUp("d")){
            anim.SetBool(anim.GetParameter(0).name, false);
        }
        if( !Input.GetKey("d") && rb2d.velocity.x >= 1 ){
            rb2d.AddForce(new Vector2( -2f , 0f ));
        }
        if( !Input.GetKey("a") && rb2d.velocity.x <= -1 ){
            rb2d.AddForce(new Vector2( 2f , 0f ));
        }if(!Input.GetKey("space")){
            anim.SetBool(anim.GetParameter(1).name, false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "KillPlayer" || collision.gameObject.tag == "Fuego"){
            GetComponent<KillPlayer>().enabled = true ;
        }if(collision.gameObject.tag == "NextScene"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}