using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public UnityEngine.Vector3 Goal = new UnityEngine.Vector3(1,0,1);
    public float Speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    /// <summary>
    /// using lateupdate so the movement only appens after everyting else
    /// </summary>
    void LateUpdate()
    {
        // multiply by deltatime to smoths the character movement
        this.transform.Translate(Goal.normalized * Speed * Time.deltaTime);   
    }
}
