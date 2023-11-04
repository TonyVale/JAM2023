using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
<<<<<<< HEAD
using System.Numerics;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameController : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
    float timerAux;
    public float LavaDoorTimer;
=======
>>>>>>> d248b22 (merge attempt)
=======
    float timerAux;
    public float LavaDoorTimer;
>>>>>>> 4d978c0 (Scene 2)
    public bool RespawnEnabled; 
    public GameObject PlayerPrefab;
    GameObject Player;
    GameObject[] SpawnPoint;
<<<<<<< HEAD
<<<<<<< HEAD
    
    public GameObject LavaDoorL;
    public GameObject LavaDoorR;

    private UnityEngine.Vector3 AuxDoor1;
    private UnityEngine.Vector3 AuxDoor2;
    
    private UnityEngine.Vector3 CamVel = new UnityEngine.Vector3(10,10,0);
    public GameObject Cam;

    private UnityEngine.Vector3 doorsVel = UnityEngine.Vector3.zero; 
=======
    GameObject[] SpawnPointLevels;
=======
    
    public GameObject LavaDoorL;
    public GameObject LavaDoorR;
>>>>>>> 4d978c0 (Scene 2)

<<<<<<< HEAD
    public GameObject[] Levels;
<<<<<<< HEAD
=======
    private UnityEngine.Vector3 AuxDoor1;
    private UnityEngine.Vector3 AuxDoor2;
>>>>>>> 8e9ff6d (Scene 2)
    
    private UnityEngine.Vector3 CamVel = new UnityEngine.Vector3(10,10,0);
    public GameObject Cam;
<<<<<<< HEAD
>>>>>>> d248b22 (merge attempt)
=======

    private UnityEngine.Vector3 doorsVel = UnityEngine.Vector3.zero; 
>>>>>>> 4d978c0 (Scene 2)
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){
<<<<<<< HEAD
<<<<<<< HEAD
        
=======

>>>>>>> d248b22 (merge attempt)
=======
        
>>>>>>> 4d978c0 (Scene 2)
        SpawnPoint = GameObject.FindGameObjectsWithTag("Respawn");
    }
    // Start is called before the first frame update
    void Start(){
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        timerAux = LavaDoorTimer;
        AuxDoor1 = LavaDoorR.GetComponent<Transform>().position;
        AuxDoor2 = LavaDoorL.GetComponent<Transform>().position;
=======
=======
=======
>>>>>>> 4d978c0 (Scene 2)
=======
=======
using System.Numerics;
>>>>>>> 0b14882 (Player Finish)
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameController : MonoBehaviour
{
    public bool RespawnEnabled; 
    public GameObject PlayerPrefab;
    GameObject Player;
    GameObject[] SpawnPoint;
=======
>>>>>>> 301665c (LevelConfig)
    
    private UnityEngine.Vector3 CamVel = new UnityEngine.Vector3(10,10,0);
    public GameObject Cam;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){

        SpawnPoint = GameObject.FindGameObjectsWithTag("Respawn");
    }
    // Start is called before the first frame update
<<<<<<< HEAD
    void Start()
    {
>>>>>>> 04d7f84 (movment first commi)
<<<<<<< HEAD
>>>>>>> f7c7bb8 (movment first commi)
=======
=======
    void Start(){
>>>>>>> 0b14882 (Player Finish)
>>>>>>> 024019d (Player Finish)
        
<<<<<<< HEAD
>>>>>>> d248b22 (merge attempt)
=======
=======
        timerAux = LavaDoorTimer;
        AuxDoor1 = LavaDoorR.GetComponent<Transform>().position;
        AuxDoor2 = LavaDoorL.GetComponent<Transform>().position;
>>>>>>> 8e9ff6d (Scene 2)
>>>>>>> 4d978c0 (Scene 2)
    }

    // Update is called once per frame
<<<<<<< HEAD
<<<<<<< HEAD
    void Update(){
        
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        LavaDoorTimer -= Time.deltaTime;

        if(LavaDoorTimer<= 0.0f){
            LavaDoorR.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorR.GetComponent<Transform>().position, AuxDoor1 + new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
            LavaDoorL.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorL.GetComponent<Transform>().position, AuxDoor2 - new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
        }

=======
=======
    void Update(){
>>>>>>> 0b14882 (Player Finish)
>>>>>>> 024019d (Player Finish)
=======
=======
>>>>>>> 4d978c0 (Scene 2)
=======
    void Update(){
>>>>>>> 0b14882 (Player Finish)
=======
>>>>>>> 301665c (LevelConfig)
<<<<<<< HEAD
>>>>>>> 9439097 (LevelConfig)
=======
=======
        LavaDoorTimer -= Time.deltaTime;

        if(LavaDoorTimer<= 0.0f){
            LavaDoorR.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorR.GetComponent<Transform>().position, AuxDoor1 + new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
            LavaDoorL.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(LavaDoorL.GetComponent<Transform>().position, AuxDoor2 - new UnityEngine.Vector3(4,0,0), ref doorsVel, 0.05f );
        }

>>>>>>> 8e9ff6d (Scene 2)
>>>>>>> 4d978c0 (Scene 2)
        if(Input.GetKey("space")){
            if(GameObject.FindGameObjectsWithTag("Player").Length == 0){
                LavaDoorTimer = timerAux;
                LavaDoorR.GetComponent<Transform>().position = AuxDoor1;
                LavaDoorL.GetComponent<Transform>().position = AuxDoor2;
<<<<<<< HEAD
=======
        if(Input.GetKey("space")){
            if(GameObject.FindGameObjectsWithTag("Player").Length == 0){
>>>>>>> d248b22 (merge attempt)
=======
>>>>>>> 4d978c0 (Scene 2)
                Player = Instantiate(PlayerPrefab, SpawnPoint[0].GetComponent<Transform>());
            }
        }
        if(GameObject.FindGameObjectsWithTag("Player").Length == 1){
            Player = GameObject.FindGameObjectsWithTag("Player")[0];
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,2,-1), ref CamVel, 0.1f );
        }

        

=======
=======
>>>>>>> 024019d (Player Finish)
=======
>>>>>>> 9439097 (LevelConfig)
=======
>>>>>>> 4746787 (Niveles 1 y 2)
=======
>>>>>>> 4d978c0 (Scene 2)
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,2,-1), ref CamVel, 0.5f );
=======
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,3,-1), ref CamVel, 0.5f );
>>>>>>> 301665c (LevelConfig)
=======
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,2,-1), ref CamVel, 0.5f );
>>>>>>> e1c75f2 (Niveles 1 y 2)

=======
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,2,-1), ref CamVel, 0.1f );
>>>>>>> 8e9ff6d (Scene 2)
        }
<<<<<<< HEAD
>>>>>>> d248b22 (merge attempt)
=======

        

>>>>>>> 4d978c0 (Scene 2)
    }
}
<<<<<<< HEAD
 
=======
    void Update()
    {
        
=======
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,0,-1), ref CamVel, 0.5f );
        }
>>>>>>> 0b14882 (Player Finish)
    }
}
>>>>>>> 04d7f84 (movment first commi)
=======
 
>>>>>>> e1c75f2 (Niveles 1 y 2)
