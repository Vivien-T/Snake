using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Movement snakeMovement;
    // Start is called before the first frame update
    void Start()
    {
        snakeMovement = GameObject.Find("Snake_Head").GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            snakeMovement.ModifOrientation(false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            snakeMovement.ModifOrientation(true);
        }
        
    }
}
