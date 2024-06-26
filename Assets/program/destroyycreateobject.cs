using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyycreateobject : MonoBehaviour
{
    private Rigidbody2D rd;

     void Awake()
     {
        rd = GetComponent<Rigidbody2D>();
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1") {
            Destroy(this.gameObject);
        }
    }
}
