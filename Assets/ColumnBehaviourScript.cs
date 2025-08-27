using UnityEngine;

public class ColumnBehaviourScript : MonoBehaviour
{
    public float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
