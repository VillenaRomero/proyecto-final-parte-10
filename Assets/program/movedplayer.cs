using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class movedplayer : NewBehaviourScript
{
    public float horizontal;
    public float vertical;
    public float speedx;
    public float speedy;
    private Rigidbody2D _compRigidbody2D;
    public GameObject bulletprefab;
    private SpriteRenderer _comSpriteRenderer;

    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (0 < horizontal)
        {
            _comSpriteRenderer.flipX = false;

        }
        if (0 > horizontal){
            _comSpriteRenderer.flipX = true;
        }
        if(0 < vertical )
        {
            _comSpriteRenderer.flipY = false;
        }
        if (0 > vertical ) {
            _comSpriteRenderer.flipY = true;
        }
        _compRigidbody2D.velocity = new Vector2(speedx * horizontal, speedy * vertical);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bulletprefab, transform.position, transform.rotation);
        }
        
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombi")
        {
            life = life - 1;
            
            if (life == 0) {

              SceneManager.LoadScene("death");

            }
        }
    }
}
