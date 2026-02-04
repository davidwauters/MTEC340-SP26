using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float Speed = 3.0f;

    Vector2 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction.x = Random.value > 0.5f ? 1 : -1;
        direction.y = Random.value > 0.5f ? 1 : -1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Speed * Time.deltaTime * direction;
        transform.Translate(movement);
    }
}
