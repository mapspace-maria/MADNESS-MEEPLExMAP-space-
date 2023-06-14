using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public int coins;

    // The audio source for the sound effect
    public AudioSource audioSource;

    // The audio clip for the sound effect
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin");
        Destroy(Col.gameObject);

        coins++;
        ScoreManager.Instance.UpdateScore(coins);


        // Play the sound effect
        audioSource.PlayOneShot(soundEffect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
