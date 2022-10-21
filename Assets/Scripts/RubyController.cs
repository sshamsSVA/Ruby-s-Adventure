using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        // Declared postion variable and set it equal to player's position
        Vector2 position = transform.position;
        // Update player's x position .1 unit every frame
        position.x = position.x + 0.1f * horizontal * Time.deltaTime * speed; 
        position.y = position.y + 0.1f * vertical * Time.deltaTime * speed;
        transform.position = position;
    }
}
