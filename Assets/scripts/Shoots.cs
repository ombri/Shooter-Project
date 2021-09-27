using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shoots : MonoBehaviour
{
    public Weapons weapons;
    public Camera cam;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
        {
            Debug.LogError("pas de camera renseigné pour tirer");
            this.enabled = false;

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClip;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        GetComponent<AudioSource>().Play();
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, weapons.range))
        {
            Debug.Log("touché " + hit.collider.name);
            if ((hit.collider.name == "1P") || hit.collider.name == "3P" || hit.collider.name == "5P" || hit.collider.name == "7P" || hit.collider.name == "10P")
            {
                scoring.instance.AddScore(hit.collider.name);
            }
        }
    }
}
