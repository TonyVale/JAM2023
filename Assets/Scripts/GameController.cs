using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameController : MonoBehaviour
{
    float timerAux;
    public float LavaDoorTimer;
    public bool RespawnEnabled; 
    public GameObject PlayerPrefab;
    GameObject Player;
    GameObject[] SpawnPoint;
    
    public GameObject LavaDoorL;
    public GameObject LavaDoorR;

    private UnityEngine.Vector3 AuxDoor1;
    private UnityEngine.Vector3 AuxDoor2;
    
    private UnityEngine.Vector3 CamVel = new UnityEngine.Vector3(10,10,0);
    public GameObject Cam;

    private UnityEngine.Vector3 doorsVel = UnityEngine.Vector3.zero; 
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
        
        SpawnPoint = GameObject.FindGameObjectsWithTag("Respawn");
    }
    // Start is called before the first frame update
    void Start(){
        timerAux = LavaDoorTimer;
        AuxDoor1 = LavaDoorR.GetComponent<Transform>().position;
        AuxDoor2 = LavaDoorL.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update(){
        
        LavaDoorTimer -= Time.deltaTime;

        if(LavaDoorTimer<= 0.0f){
            LavaDoorR.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorR.GetComponent<Transform>().position, AuxDoor1 + new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
            LavaDoorL.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorL.GetComponent<Transform>().position, AuxDoor2 - new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
        }

        if(Input.GetKey("space")){
            if(GameObject.FindGameObjectsWithTag("Player").Length == 0){
                LavaDoorTimer = timerAux;
                LavaDoorR.GetComponent<Transform>().position = AuxDoor1;
                LavaDoorL.GetComponent<Transform>().position = AuxDoor2;
                Player = Instantiate(PlayerPrefab, SpawnPoint[0].GetComponent<Transform>());
            }
        }
        if(GameObject.FindGameObjectsWithTag("Player").Length == 1){
            Player = GameObject.FindGameObjectsWithTag("Player")[0];
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,2,-1), ref CamVel, 0.1f );
        }

        

    }
}
 