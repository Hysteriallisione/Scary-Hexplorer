using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class followme : MonoBehaviour
{
    
    private Vector3 camPlayer = new Vector3(0, 0, -10);

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        this.transform.position = player.transform.position + camPlayer;
    }
}
