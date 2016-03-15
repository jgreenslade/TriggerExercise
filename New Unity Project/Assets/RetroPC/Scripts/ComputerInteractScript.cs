using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComputerInteractScript : MonoBehaviour {

    public Canvas canvas;

    public Canvas canvas2;

    private Text textComponent;

    private bool interacting;

    private string[] msg = { "Press X to interact with this Computer.", "Congrats!\n The code is 1234. " };

    /// <summary>
    /// Later just make an array of all the things to be displayed
    /// </summary>

	// Use this for initialization
	void Start () {
        canvas.enabled = false;
        canvas2.enabled = false;
        interacting = false;

        textComponent = canvas.transform.FindChild("InteractText").gameObject.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (interacting) {
            canvas.enabled = false;
            canvas2.enabled = true;
            //textComponent.text = msg[1];
        }
	}

    void OnTriggerEnter(Collider otherCollider) {
        GameObject other = otherCollider.gameObject;
        if (other.tag == "Player")
        {
            canvas.enabled = true;

        }
    }

    void OnTriggerStay(Collider otherCollider)
    {
        GameObject other = otherCollider.gameObject;
        if (other.tag == "Player")
        {
            // Check for input
            if (Input.GetKey(KeyCode.X))
            {
                interacting = true;
                Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }

    void OnTriggerExit(Collider otherCollider)
    {
        GameObject other = otherCollider.gameObject;
        if (other.tag == "Player")
        {
            interacting = false;
            canvas.enabled = false;
            canvas2.enabled = false;
        }
    }
}
