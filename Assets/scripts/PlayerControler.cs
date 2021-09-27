using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float MoveSpeed;
    public Camera cam;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.z = -MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.z = +MoveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.x = -MoveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.x = +MoveSpeed * Time.deltaTime;
        }

        transform.position += movement;

        if (Input.GetKey(KeyCode.Z))
        {
            transform.position += cam.transform.forward * MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += cam.transform.forward * -MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += cam.transform.right * -MoveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += cam.transform.right * MoveSpeed * Time.deltaTime;
        }
    }
}

//possibilité d'utiliser getButtonDown("[button]") pour laisser l'utilisateur utiliser les button assignés dans unity