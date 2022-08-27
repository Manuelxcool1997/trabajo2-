using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolas : MonoBehaviour
{
    private Vector vectorPositon;
    private Vector displacement;
    [SerializeField]
    private Vector Velocity; 

    [SerializeField]
    private Vector acceleration;

    [SerializeField]
    [Range(0f, 1f)] float dampingFactor;
    float timer;
    
 
    [SerializeField] new Camera  camera;
    void Start()
    {
        vectorPositon =  new  Vector(transform.position.x, transform.position.y);
    }

    private void FixedUpdate()
    {
        
    }
    void Update()
    {
        vectorPositon.Draw(Color.blue);
        displacement.Draw(Color.red);
        Velocity.Draw(Color.green);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer == 0)
            {
               
                acceleration = new Vector(10.0f, 0);
                timer++;
                 Velocity *= 0;
            }
            else if (timer == 1)
            {
              
                acceleration = new Vector(0, 10.0f);
               
                timer++;
            }
            else if (timer == 2)
            {
                acceleration = new Vector(10.0f, 0);
                Velocity *= 0;
                timer++;
            }
            else if ((timer == 3)){

                acceleration = new Vector(0, 10.0f);
              
                timer++;
            }
            if (timer >= 4)
            {
                timer = 0;
            }

        }

        Move();
    }

    public void Move()
    {
        //displacement = Velocity * Time.deltaTime;
        Velocity = Velocity + acceleration * Time.deltaTime;
        vectorPositon = vectorPositon + Velocity * Time.deltaTime;
        print("moving");

        if(Mathf.Abs(vectorPositon.x)> camera.orthographicSize)
        {
            //Velocity *= -1;
            Velocity.x = Velocity.x * -1;
            vectorPositon.x = Mathf.Sign(vectorPositon.x) * camera.orthographicSize;
            //Velocity *= dampingFactor; // damping factor
        }
      
        if (Mathf.Abs(vectorPositon.y) > camera.orthographicSize)
        {
           /// Velocity *= -1;
            Velocity.y = Velocity.y * -1;
            vectorPositon.y = Mathf.Sign(vectorPositon.y) * camera.orthographicSize;
           // Velocity *= dampingFactor; // damping factor
        }

        transform.position = new Vector3(vectorPositon.x, vectorPositon.y,0);
    }
}
