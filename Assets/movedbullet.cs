using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedbullet : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombi")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "caja")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "barril")
        {
            Destroy(this.gameObject);
        }
    }*/
    public void OnCollisionStay2D(Collision2D collision)
    {
      if (collision.gameObject.tag == "zombi")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "caja")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "barril")
        {
            Destroy(this.gameObject);
        }  
    }
}


/*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombi")
        {
            Destroy(this.gameObject);
        }
    }*/
