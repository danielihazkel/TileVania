using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    [SerializeField] AudioClip sound;

    [SerializeField] int coinValue = 20;

    bool wasCollected =false ;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !wasCollected){
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(coinValue);
            AudioSource.PlayClipAtPoint(sound,Camera.main.transform.position);
            Destroy(gameObject);
        }
    }

}
