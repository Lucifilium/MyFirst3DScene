using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private int pickupScore = 0;
    public TextMeshProUGUI PickupText;
    public GameObject GameCompleteUI;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Collectible
        if (other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
            pickupScore++;
            PickupText.text = "Total: " + pickupScore.ToString() + "/30";

        }

        //Enable game complete screen
        if(pickupScore == 30)
        {
            GameCompleteUI.SetActive(true);
        }
    }
}
