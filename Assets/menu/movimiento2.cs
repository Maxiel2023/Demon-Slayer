using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento2 : MonoBehaviour
{
    public Transform puntodeataque;
    public Transform puntodeataque2;
    public Transform puntodeataque3;
    [SerializeField] private float TiempoEntreAtaques;
    [SerializeField] private float TiempoSiguienteAtaque;
    [SerializeField] private float TiempoAtaques;
    [SerializeField] private float TiempoSiguiente;
    [SerializeField] private float TiempoAtaque;
    [SerializeField] private float TiempoSig;
    [SerializeField] private float TiempoDefensa;
    [SerializeField] private float TiempoSigDefensa;

    [SerializeField] private AudioClip DañoSonido; 
    [SerializeField] private AudioClip ataqueSonido;
    [SerializeField] private AudioClip SaltoSonido;
    [SerializeField] private AudioClip ataqueSonido2;

    public float Rangodeataque = 0.5f;
    public float Rangodeataque2 = 0.5f;
    public float Rangodeataque3 = 0.5f;

    public int Ataque1;
    public int Ataque2;
    public int Ataque3;

    bool canjump;
    private Animator an;
    private Rigidbody2D rb;
    private bool mirandoderecha = true;
    float inputX;
    public LayerMask enemylayers;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

         if(TiempoSiguienteAtaque > 0)
        {
            TiempoSiguienteAtaque -= Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.B) && TiempoSiguienteAtaque <= 0)
        {
           TiempoSiguienteAtaque = TiempoEntreAtaques;
           an.SetBool("ATACALO", true);
           ControladorSonido.Instance.EjecutarSonido(ataqueSonido);
           
        }
        else
        {
            an.SetBool("ATACALO", false);
        }


         if(TiempoSiguiente > 0)
        {
            TiempoSiguiente -= Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.N) && TiempoSiguiente <= 0)
        {
           TiempoSiguiente = TiempoAtaques;
           an.SetBool("ATACALO2", true);
           ControladorSonido.Instance.EjecutarSonido(ataqueSonido);
           ControladorSonido.Instance.EjecutarSonido(ataqueSonido2);
           
        }
        else
        {
            an.SetBool("ATACALO2", false);
        }



         if(TiempoSig > 0)
        {
            TiempoSig -= Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.M) && TiempoSig <= 0)
        {
           TiempoSig = TiempoAtaque;
           an.SetBool("ATACALO3", true);
           ControladorSonido.Instance.EjecutarSonido(ataqueSonido);
           ControladorSonido.Instance.EjecutarSonido(ataqueSonido2);
           
        }
        else
        {
            an.SetBool("ATACALO3", false);
        }





        if(Input.GetKey(KeyCode.A))
        {
            inputX = -1f;
            rb.AddForce(new Vector2(-1000f * Time.deltaTime, 0));
           an.SetBool("MOVETE", true);
        }

        else
        {
           an.SetBool("MOVETE", false); 
        }

           if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1000f * Time.deltaTime, 0));
            inputX = 1f;
           an.SetBool("MOVETE", true);
        }
        
        if((inputX > 0 && !mirandoderecha) || (inputX < 0 && mirandoderecha))
        {
            mirandoderecha = !mirandoderecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);

        }  



         if(Input.GetKeyDown(KeyCode.W) && canjump)
        {
            rb.AddForce(new Vector2(0, 600));
           an.SetBool("SALTA", true);
            canjump = false;
            ControladorSonido.Instance.EjecutarSonido(SaltoSonido);
        }

         if(TiempoSigDefensa > 0)
        {
            TiempoSigDefensa -= Time.deltaTime;
        }

         if(Input.GetKey(KeyCode.L) && TiempoSigDefensa <= 0)
        {
            TiempoSigDefensa = TiempoDefensa;
            an.SetBool("Defensa", true);
            gameObject.layer = 10;
        }
        else
        {
            an.SetBool("Defensa", false);
            gameObject.layer = 9;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground" || collision.transform.tag == "Jugador1")
        {
            gameObject.GetComponent<Animator>().SetBool("SALTA", false);
            canjump = true;
        }
    }



    

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntodeataque.position, Rangodeataque, enemylayers);
        foreach(Collider2D collisionador in hitEnemies)
        {
            collisionador.GetComponent<enemigo>().TakeDamage(Ataque1);
            ControladorSonido.Instance.EjecutarSonido(DañoSonido);

        }
    }

     void Attack2()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntodeataque2.position, Rangodeataque2, enemylayers);
        foreach(Collider2D collisionador in hitEnemies)
        {
            
            collisionador.GetComponent<enemigo>().TakeDamage(Ataque2);
            ControladorSonido.Instance.EjecutarSonido(DañoSonido);

        }
    }

     void Attack3()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntodeataque3.position, Rangodeataque3, enemylayers);
        foreach(Collider2D collisionador in hitEnemies)
        {
            collisionador.GetComponent<enemigo>().TakeDamage(Ataque3);
            ControladorSonido.Instance.EjecutarSonido(DañoSonido);

        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(puntodeataque.position, Rangodeataque);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(puntodeataque2.position, Rangodeataque2);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(puntodeataque3.position, Rangodeataque3);
    }

    public void Fortaleza(int fuerza)
    {
        Ataque1 += fuerza;
        Ataque2 += fuerza;
        Ataque3 += fuerza;
    }

}
