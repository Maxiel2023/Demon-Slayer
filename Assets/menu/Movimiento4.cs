using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento4 : MonoBehaviour
{
   public Transform puntodeatak;
    public float Rangodeatak = 0.5f;
    public LayerMask enemylayers;
    
    bool canjump;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            gameObject.GetComponent<Animator>().SetBool("MOVETE", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("MOVETE", false);
        }


         if(Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            gameObject.GetComponent<Animator>().SetBool("MOVETE", true);

        }


        if(Input.GetKeyDown("up") && canjump)

        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            canjump = false;
            gameObject.GetComponent<Animator>().SetBool("SALTA", true);
        }

         if(Input.GetButton("Fire1"))
        {
            gameObject.GetComponent<Animator>().SetBool("ATACALO", true);
            Attack();
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("ATACALO", false);
            
        }

        
        
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            gameObject.GetComponent<Animator>().SetBool("SALTA", false);
            canjump = true;
        }
    }

     void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntodeatak.position, Rangodeatak, enemylayers);
        
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemigo>().TakeDamage(2);
        }
    }

    void OnDrawGizmosSelected()
    {
        if(puntodeatak == null)
        return;
        Gizmos.DrawWireSphere(puntodeatak.position, Rangodeatak);
    }

}
