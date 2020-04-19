using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    

    public Vector2 orientation;

    // Start is called before the first frame update
    void Start()
    {
        orientation = new Vector2(0, 0.01F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(orientation);
        
    }

    public void ModifOrientation(bool inputRight)
    {
        if (inputRight)
        {
            orientation = RotateVector(orientation, -1);
        }
        else
        {
            orientation = RotateVector(orientation, 1);
        }
    }

    public Vector2 RotateVector(Vector2 v, float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float _x = v.x * Mathf.Cos(radian) - v.y * Mathf.Sin(radian);
        float _y = v.x * Mathf.Sin(radian) + v.y * Mathf.Cos(radian);
        return new Vector2(_x, _y);
    }

    void OnTriggerEnter()
    {
        if (this.gameObject.GetComponent<BoxCollider2D>().isTrigger)
        {
            print("you lose");
        }
    }
}
