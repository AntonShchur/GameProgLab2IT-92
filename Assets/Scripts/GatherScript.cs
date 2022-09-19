using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GatherScript : MonoBehaviour
{
    public GameObject mushroom;
    private ScoreCounter sc;
    private void OnTriggerEnter(Collider other)
    {
        sc = FindObjectOfType<ScoreCounter>();
        if (other.tag == "Player")
            sc.IncreaseScore();
            Destroy(mushroom);
    }
}
