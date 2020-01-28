using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Duck;
    float timer = 0;
    float waitTime = 50;

    void Update()
    {
        Move();
    }

    void Move()
    {
        timer += 1;
        // Debug.Log(timer);
        if (timer > waitTime)
        {
            timer = 0;

            Direction();

            Correction();
        }
    }

    void Direction()
    {
        int direction = Random.Range(1, 8);
        if (direction == 1)
        {
            Duck.transform.Translate(Vector3.up);
            Debug.Log("Up");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 2)
        {
            Duck.transform.Translate(Vector3.up);
            Duck.transform.Translate(Vector3.right);
            Debug.Log("Up Right");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 3)
        {
            Duck.transform.Translate(Vector3.right);
            Debug.Log("Right");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 4)
        {
            Duck.transform.Translate(Vector3.right);
            Duck.transform.Translate(Vector3.down);
            Debug.Log("Down Right");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 5)
        {
            Duck.transform.Translate(Vector3.down);
            Debug.Log("Down");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 6)
        {
            Duck.transform.Translate(Vector3.down);
            Duck.transform.Translate(Vector3.left);
            Debug.Log("Down Left");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 7)
        {
            Duck.transform.Translate(Vector3.left);
            Debug.Log("Left");
            Debug.Log(transform.localPosition);
        }

        else if (direction == 8)
        {
            Duck.transform.Translate(Vector3.left);
            Duck.transform.Translate(Vector3.up);
            Debug.Log("Up Left");
            Debug.Log(transform.localPosition);
        }
    }

    void Correction()
    {
        if (transform.localPosition.x == 11)
        {
            for (int i = 0; i < 2; i++)
            {
                Duck.transform.Translate(Vector3.left);
            }
            Debug.Log("Cor left");
            Debug.Log(transform.localPosition);
        }

        else if (transform.localPosition.x == -11)
        {
            for (int i = 0; i < 2; i++)
            {
                Duck.transform.Translate(Vector3.right);
            }
            Debug.Log("Cor Right");
            Debug.Log(transform.localPosition);
        }

        else if (transform.localPosition.y == 4)
        {
            for (int i = 0; i < 2; i++)
            {
                Duck.transform.Translate(Vector3.down);
            }
            Debug.Log("Cor Down");
            Debug.Log(transform.localPosition);
        }

        else if (transform.localPosition.y == -4)
        {
            for (int i = 0; i < 2; i++)
            {
                Duck.transform.Translate(Vector3.up);
            }
            Debug.Log("Cor Up");
            Debug.Log(transform.localPosition);
        }
    }
}
