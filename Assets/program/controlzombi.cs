using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlzombi : NewBehaviourScript
{
    public GameObject objective;
    public zonazombi avanzar;
    private Rigidbody2D rd;

    private void Awake()
    {
        rd = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (avanzar.ischasingplayer==true)
        {
            transform.position = Vector2.MoveTowards(transform.position, objective.transform.position, speed * Time.deltaTime);
        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            life = life - 1;
          if (life == 0)
          {
            Destroy(this.gameObject);
          }
        }
    }
}
