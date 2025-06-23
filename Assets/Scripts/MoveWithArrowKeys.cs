using UnityEngine;

public class MoveWithArrowKeys : MonoBehaviour
{
    public GameObject target; // The object to move
    public float speed = 5f;  // Movement speed

    void Awake()
    {
        if (target == null)
        {
            target = gameObject;
        }
    }

    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveX = 1f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY = 1f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY = -1f;
        }

        Vector3 moveDir = new Vector3(moveX, moveY, 0f).normalized;
        target.transform.position += moveDir * speed * Time.deltaTime;
    }
}
