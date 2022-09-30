using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pipes : MonoBehaviour
{
  public  float speed ;
    public float destroyTime;
    // Start is called before the first frame update
    void Start()
    {
      
        Destroy(gameObject,destroyTime);
    }

    // Update is called once per frame
    void  FixedUpdate()
    { 
        transform.position += Vector3.left * speed * Time.deltaTime;
    } 
}
