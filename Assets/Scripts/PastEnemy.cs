using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastEnemyMovement : MonoBehaviour
{

    float horizontalMovement;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
