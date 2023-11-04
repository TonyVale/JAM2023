using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameController : MonoBehaviour
{
    public bool RespawnEnabled; 
    public GameObject PlayerPrefab;
    GameObject Player;
    GameObject[] SpawnPoint;
    
    private UnityEngine.Vector3 CamVel = new UnityEngine.Vector3(10,10,0);
    public GameObject Cam;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake(){

        RespawnEnabled = false;
        SpawnPoint = GameObject.FindGameObjectsWithTag("Respawn");
        
    }
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey("space")){
            if(GameObject.FindGameObjectsWithTag("Player").Length == 0){
                Player = Instantiate(PlayerPrefab, SpawnPoint[0].GetComponent<Transform>());
            }
        }
        if(GameObject.FindGameObjectsWithTag("Player").Length == 1){
            Player = GameObject.FindGameObjectsWithTag("Player")[0];
            Cam.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp(Cam.GetComponent<Transform>().position, Player.GetComponent<Transform>().position + new UnityEngine.Vector3(0,0,-1), ref CamVel, 0.5f );
        }
    }
}
