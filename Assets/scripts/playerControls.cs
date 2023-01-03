using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
using static UnityEngine.GraphicsBuffer;


public class playerControls : MonoBehaviour
{
    public Rigidbody2D rigidB;
    private Vector2 playerVect;
    public float rapide;
    public float Horizontal;
    public float Vertical;
    public Animator animaP;
    
    private bool colliderP;
    private Collider2D target;
    private GameObject player;

    public GameObject coffre;
    public Loot lootScript;
    public bool opening = false;

    public float health;
    public float damage;

    public EnemyZombie zombScr;
    public EnemyShadow shadScr;
    public GameManager gameM;
    public ActionPlayer inputPlayer;

   
    private bool move;
    private bool attack;
    private bool pause;
   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        zombScr = GetComponent<EnemyZombie>();
        shadScr = GetComponent<EnemyShadow>();
        gameM = GetComponent<GameManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        move = false;
         Vector2 movingP = new Vector2(Horizontal, Vertical);
         playerVect = movingP.normalized * rapide;
         Horizontal = transform.position.x;
         Vertical = transform.position.y;
       

        // if ( startZeG)
        //{
        if (movingP.magnitude > 0)
        {
            move = true;
            animaP.SetFloat("Horizontal", movingP.x);
            animaP.SetFloat("Vertical", movingP.y);
            animaP.SetBool("Move", true);
           
        }
        else
        {
            move = false;
            animaP.SetBool("Move", false);
        }

        if (attack && colliderP)
        {
            PlayerAction();
            if(lootScript.open)
            {
                opening = true;
            }
           
        }
        else
        {
            animaP.SetBool("Attack", false);
        }
        if(pause)
        {
            gameM.Pause();
        }
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        Vector2 movingP = new Vector2(Horizontal, Vertical);
        playerVect = movingP.normalized * rapide;
        Horizontal = transform.position.x;
        Vertical = transform.position.y;
        rigidB.velocity = ctx.ReadValue<Vector2>() * rapide;
        rigidB.MovePosition(rigidB.position + playerVect * Time.fixedDeltaTime * rapide);
    }


  /*  private void FixedUpdate()
    {
        Rigidbody2D rigidB = player.gameObject.GetComponent<Rigidbody2D>();
        rigidB.MovePosition(rigidB.position + playerVect * Time.fixedDeltaTime * rapide);
      
    }*/
    public void PlayerAction()
    {
        animaP.SetBool("Attack", true);
        zombScr.health -= this.damage;
        shadScr.health -= this.damage;
        // destroy l'empty gameobject ("collider") contenant le collider "target"
        Debug.Log("j'essaie de tuer!!!");

       
    }
    public void Death()
    {

        if (health <= 0)
        {
        Debug.Log("DEAD PLAYER");
        animaP.SetBool("Dead", true);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            colliderP = true;
            target = collision;
            Debug.Log("trigger has been touched on enemy");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            colliderP = false;
            target = null;
        }
    }
}
