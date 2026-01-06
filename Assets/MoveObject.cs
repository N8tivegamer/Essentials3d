using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public int speed;
    public bool goingRight=false;
    public float bounds = 6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Moves object in a direction 
        transform.Translate(Vector3.right *speed * Time.deltaTime);// Frame indpendent 

        if (transform.position.x >= bounds && goingRight)
        {
            goingRight = false;
            speed = -speed;
        }
        else if (transform.position.x <= -bounds && goingRight == false) 
        {
            goingRight = true;
            speed = -speed;
        }
    }
}
