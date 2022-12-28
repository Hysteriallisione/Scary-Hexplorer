using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class startAtt : MonoBehaviour
{
    public EnemyZombie zombScript;
    public GameObject zombiz;
    public Collider2D meTrigger;
    public bool wakeUp = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( wakeUp)
        {
            zombScript.WalkToward();

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wakeUp = true;
            meTrigger = collision;
            Debug.Log("trigger has been touched");
        }
    }
}
