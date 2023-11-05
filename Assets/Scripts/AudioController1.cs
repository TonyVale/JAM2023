using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController1 : MonoBehaviour
{
    bool flag;
    public AudioSource Inicio;
    public AudioSource Final;

    // Start is called before the first frame update
    void Start()
    {
        flag = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Inicio.isPlaying == false &&  flag == false && Final.isPlaying == false ){
            Final.Play();
            flag = true;
        }if(Inicio.isPlaying == false &&  flag == true && Final.isPlaying == false ){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
