using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // configuration parameters
    [SerializeField] float screenWidth = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidth;
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);

        paddlePosition.x = Mathf.Clamp(mousePositionInUnits, minX, maxX);
        transform.position = paddlePosition;
    }
}
