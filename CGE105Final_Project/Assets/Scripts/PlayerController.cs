using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    // public Animator Panim;

    Animator animator;
     Rigidbody2D PRb;
    public float speed=1f;
    [SerializeField]int jumpforce;
    bool facingright;
    public ParticleSystem PJetSmoke;
    

    //For Shooting
    public Transform gunTip;
    public GameObject bullet;
    float FireRate = 0.5f;
    float nextFire = 0f;

    



    void Start()
    {
       
        
        animator= GetComponent<Animator>();
        PRb = GetComponent<Rigidbody2D>();
        PJetSmoke = GetComponentInChildren<ParticleSystem>();
        facingright = true;

        

        
    }

    

    void Update()
    {
        
        float move;
        move = Input.GetAxisRaw("Horizontal");
        PRb.velocity = new Vector2(move * speed, PRb.velocity.y);

        //Panim.SetFloat("Speed", Mathf.Abs(move));
        if (move == 0)
        {

            animator.SetBool("isRunning", false);

        }
        else
        {
            animator.SetBool("isRunning", true);
            //transform.Translate(Vector3.right);
        }

        if (move > 0 && !facingright)
        {
            flip();
        }else if (move < 0 && facingright)
        {
            flip();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            PRb.AddForce(Vector2.up * jumpforce);
            animator.SetBool("isRunning", false) ;
            

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PJetSmoke.Play();

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PJetSmoke.Stop();

        }


        void flip()
        {
        facingright =! facingright;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        }


        //Shooting
        if (Input.GetAxisRaw("Fire1") > 0) 
        
        { 
            Shoot(); 

        } 



    }
    
    void CreatePJetSmoke()
    {
        PJetSmoke.Play();
    }
    void Shoot()
    {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;
            if (facingright)
            {
                Instantiate(bullet, gunTip.position,Quaternion.Euler(new Vector3(0,0,0)));
            }else if (!facingright)
            {
                Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 180f)));
            }
        }

    }

    //PlayerCrashEnemy
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "Enemy")
        {
            HealthManager.health--;

        }
    }

    

}
