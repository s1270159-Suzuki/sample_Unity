using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.FPS.Gameplay;

public class poison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider t)
    {
        if(t.gameObject.tag == "Player"){
            StartCoroutine(DelayCoroutine(t));
        }
    }

    private IEnumerator DelayCoroutine(Collider t)
    {
        t.gameObject.GetComponent<PlayerCharacterController>().MaxSpeedOnGround = 3f;
        t.gameObject.GetComponent<PlayerCharacterController>().MaxSpeedInAir = 2f;

        yield return new WaitForSeconds(3);

        t.gameObject.GetComponent<PlayerCharacterController>().MaxSpeedOnGround = 10f;
        t.gameObject.GetComponent<PlayerCharacterController>().MaxSpeedInAir = 10f;
    }
}
