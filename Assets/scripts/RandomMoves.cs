using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoves : MonoBehaviour
{
    private float randY = UnityEngine.Random.Range(0, 2);
    private float randZ = UnityEngine.Random.Range(18, 43);
    private float randX = UnityEngine.Random.Range(-23, 15);

    public float MoveSpeed;

    public bool loop = true;

    private void Start()
    {
        StartCoroutine(Looping());
    }
    IEnumerator Looping()
    {
        Vector3 movement = Vector3.zero;
        while (loop){
            movement.y = randY * MoveSpeed * Time.deltaTime;
            movement.z = randZ * MoveSpeed * Time.deltaTime;
            movement.x = randX * MoveSpeed * Time.deltaTime;
            transform.position += movement;
            yield return new WaitForSecondsRealtime(10);
            Looping();
        }

    }
}
