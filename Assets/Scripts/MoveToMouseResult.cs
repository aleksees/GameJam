using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class MoveToMouseResult : MonoBehaviour
{
    public bool isMoving = false;
    private Vector3 TPosition;
    public float speed;
    void Start()
    {
        GetComponent<MoveToMouseResult>().enabled = false;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "colider")
        {
            isMoving = false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            TriggerPosition();
        }

        if (isMoving)
        {
            ItsMove();
        }

    }
    void TriggerPosition()
    {
        TPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        TPosition.z = transform.position.z;

        isMoving = true;
    }

    void ItsMove()
    {
        transform.position = Vector3.MoveTowards(transform.position, TPosition, speed * Time.deltaTime);
        Vector3 diference = TPosition - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ - 90f);
        if (transform.position == TPosition)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);
            isMoving = false;
        }
    }
}
