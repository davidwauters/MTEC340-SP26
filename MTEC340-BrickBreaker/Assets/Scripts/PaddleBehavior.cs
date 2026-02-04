using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;
    public float MinX = -6.0f;
    public float MaxX = 6.0f;
    
    private int activeDirection = 0;
    void Start()
    {
        
    }

    void Update()
    {
        var keyboard = Keyboard.current;

        if (keyboard.aKey.wasPressedThisFrame)
            activeDirection = -1;

        if (keyboard.dKey.wasPressedThisFrame)
            activeDirection = 1;

        if (activeDirection == -1 && keyboard.aKey.wasReleasedThisFrame)
            activeDirection = 0;

        if (activeDirection == 1 && keyboard.dKey.wasReleasedThisFrame)
            activeDirection = 0;
        
        float movement = activeDirection * Speed * Time.deltaTime;
        float nextX = transform.position.x + movement;

        if (nextX >= MinX && nextX <= MaxX)
        {
            transform.Translate(Vector3.right * movement);
        }
    }
}
