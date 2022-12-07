using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{

    public GameObject upArrow;
    public GameObject challengeArrow;
    public GameObject exitGate;
    public GameObject blockerGate;
    public GameObject challengeEntranceGate;
    public GameObject challengeExitGate;
    public GameObject Ghost;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            upArrow.SetActive(true);

            challengeArrow.SetActive(false);

            exitGate.SetActive(false);

            blockerGate.SetActive(true);

            challengeEntranceGate.SetActive(false);

            challengeExitGate.SetActive(false);

            Ghost.SetActive(true);
        }
    }
}
