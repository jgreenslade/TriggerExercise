using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorInteractScript : MonoBehaviour {

    public Canvas canvas;

    public InputField codeInputField;

    private bool interacting;

    private string[] msg = { "Press X to interact with this Computer.", "Congrats!\n The code is 1234. " };
    private Material mat;
    /// <summary>
    /// Later just make an array of all the things to be displayed
    /// </summary>

	// Use this for initialization
	void Start () {
        canvas.enabled = false;
        interacting = false;

        // Add listener for submit value
        InputField.SubmitEvent submitEvent = new InputField.SubmitEvent();
        submitEvent.AddListener(submitValue);
        codeInputField.onEndEdit = submitEvent;

        mat = this.gameObject.GetComponent<Renderer>().material;
    }

    void submitValue(string code) {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        if (code.Equals("1234")) {
            if (mat != null)
            {
                mat.color = Color.green;
            }
            else {
                Debug.Log("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
            }
            }
    }

    // Update is called once per frame
    void Update () {

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

    }

    void OnTriggerExit(Collider otherCollider)
    {
        GameObject other = otherCollider.gameObject;
        if (other.tag == "Player")
        {
            interacting = false;
            canvas.enabled = false;
        }
    }
}
