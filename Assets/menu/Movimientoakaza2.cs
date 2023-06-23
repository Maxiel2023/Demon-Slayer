using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoakaza2 : MonoBehaviour
{
    public Transform puntodeataque;
    public float Rangodeataque = 0.5f;
    public LayerMask enemylayers;
    bool canjump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Input.GetKey(KeyCode.H))
        {
            gameObject.GetComponent<Animator>().SetTrigger("atacarr");
            Attack();
        }
        if(Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("movimiento", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        else
        {
           gameObject.GetComponent<Animator>().SetBool("movimiento", false); 
        }

           if(Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("movimiento", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

          if(Input.GetKeyDown(KeyCode.W) && canjump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500));
            gameObject.GetComponent<Animator>().SetBool("salto", true);
            canjump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            gameObject.GetComponent<Animator>().SetBool("salto", false);
            canjump = true;
        }
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntodeataque.position, Rangodeataque, enemylayers);
        
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(2);
        }
    }

    void OnDrawGizmosSelected()
    {
        if(puntodeataque == null)
        return;
        Gizmos.DrawWireSphere(puntodeataque.position, Rangodeataque);
    }
}
