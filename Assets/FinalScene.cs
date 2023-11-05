using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{

    public GameObject Princes;
    public GameObject Nuve;

    public Sprite Orca;

    bool Flag; 

    private UnityEngine.Vector3 velocity = new UnityEngine.Vector3(10,10,0);
    private UnityEngine.Vector3 aux;

    bool flag2;

    // Start is called before the first frame update
    void Start(){
        aux = Nuve.GetComponent<Transform>().position;
        Flag = false;
        flag2 = false;
    }

    // Update is called once per frame
    void Update(){
        if(Flag==true && flag2 == false){
            Nuve.GetComponent<Transform>().position =UnityEngine.Vector3.SmoothDamp( Nuve.GetComponent<Transform>().position, Princes.GetComponent<Transform>().position, ref velocity, 5f );
        }if((int)Nuve.GetComponent<Transform>().position.x == (int)Princes.GetComponent<Transform>().position.x){
            Princes.GetComponent<SpriteRenderer>().sprite = Orca;
            flag2 = true;
        }if(flag2==true){
            Nuve.GetComponent<Transform>().position = UnityEngine.Vector3.SmoothDamp( Nuve.GetComponent<Transform>().position, aux, ref velocity, 5f );
            if((int)Nuve.GetComponent<Transform>().position.x == (int)aux.x){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "Player"){
            Flag = true;
            collision.gameObject.GetComponent<Movment>().enabled = false;
        }
    }

}
