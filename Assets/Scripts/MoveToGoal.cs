using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{
    public float Speed = 1.0f;
    public float Accuracy = 0.01f;
    public Color color = Color.red;
    public Transform Goal;

    void Start()
    {
        //this make our character to look directly to our player obj
        this.transform.LookAt(Goal.position);       
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // calculate the direction vector between our character and the player obj
        Vector3 direction = Goal.position - this.transform.position;
        Debug.DrawRay(this.transform.position, new Vector3(direction.x, 0.0f, direction.z), Color.blue);

        if(direction.magnitude >= Accuracy)
        {
            Vector3 dir = new Vector3(direction.normalized.x, 0.0f, direction.normalized.z);
            this.transform.Translate(dir * Speed * Time.deltaTime, Space.World);

        }
        
    }
}
