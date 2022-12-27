using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{
    // Ze base
    public Collider2D triggerAtt;
    public GameObject player;
    public float speed;
    public float health;
    public int damage;
    public bool deleteE = false;

    //Attacking Player
    public float timeBetweenAttacks = .5f;
    private float time;
    private bool canAttack;

    //Damage Popup
    public GameObject aie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health -= damage;



        if (health <= 0)
        {
           // Loots();
            Death();
        }

        Vector3 showDamage = new Vector3(transform.position.x, 1f, transform.position.z);
        var go = Instantiate(aie, showDamage, Quaternion.identity);
        TMP_Text damageText = go.GetComponent<TMP_Text>();
        damageText.text = damage.ToString();


    }
    public void Death()
    {


        if (!deleteE)
        {
            deleteE = true;
            //Debug.Log("Dead Enemy");
           
            Destroy(this.gameObject, .1f);
        }
    }
   /* public void Loots()
    {

        if (!spawnLoot)
        {
            spawner.enemyM.enemiesDefeated++; //Putting this here because this is for defeated enemies.
            randNum = Random.Range(0, 101);


            if (randNum >= 51)
            {

                Instantiate(loots[0], transform.position, Quaternion.identity);
            }
            if (randNum > 30 && randNum <= 50)
            {

                Instantiate(loots[1], transform.position, Quaternion.identity);

            }
            if (randNum < 29)
            {

                return;
            }


            spawnLoot = true;
        }*/

    }
