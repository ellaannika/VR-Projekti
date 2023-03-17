using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shooting : MonoBehaviour
{
    public GameObject ammo;
    public Transform ammoSpawn;
    public float ammoSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(Fire);
    }

    public void Fire(ActivateEventArgs arg)
    {
        GameObject spawnedAmmo = Instantiate(ammo);
        spawnedAmmo.transform.position = ammoSpawn.position;
        spawnedAmmo.GetComponent<Rigidbody>().velocity = ammoSpawn.forward * ammoSpeed;
        Destroy(spawnedAmmo, 4);
    }
}
