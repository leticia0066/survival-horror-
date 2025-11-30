using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector2(h, v) * speed * Time.deltaTime);
    }
}
