using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float Speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        SendBallInRandomDirecton();
    }

    private void SendBallInRandomDirecton()
    {

        rigidbody2D.velocity = Vector3.zero;
        rigidbody2D.isKinematic = true;
        rigidbody2D.isKinematic = false;




        Vector2 newBallVector = new Vector2();
        newBallVector.x = Random.Range(-1f, 1f);
        newBallVector.y = Random.Range(-1f, 1f);
        rigidbody2D.velocity = newBallVector;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { }
        
    }
}
