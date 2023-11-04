using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class WaterController : MonoBehaviour
{

     public LineRenderer m_lineRenderer;
     RaycastHit2D _hit;
     
    // Start is called before the first frame update
    private void Awake(){
        
        m_lineRenderer = GetComponent<LineRenderer>(); 
        _hit = Physics2D.Raycast(transform.position, Vector2.down);
        Draw2DRay(transform.position,  new Vector2(transform.position.x , transform.position.y -_hit.distance));
    }
    void Start()
    {
        
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate(){

        if((int)m_lineRenderer.GetPosition(0).y == (int)m_lineRenderer.GetPosition(1).y){
            Destroy(this.gameObject);}
        Draw2DRay(m_lineRenderer.GetPosition(0) - new Vector3(0 , 0.1f , 0), m_lineRenderer.GetPosition(1));
    }

    
    void Draw2DRay(Vector2 startPos, Vector2 finPos){
        m_lineRenderer.SetPosition(0 , startPos);
        m_lineRenderer.SetPosition(1, finPos);
    }

    // Update is called once per frame
    void Update(){
         _hit = Physics2D.Raycast(transform.position, Vector2.down);
    }
}
