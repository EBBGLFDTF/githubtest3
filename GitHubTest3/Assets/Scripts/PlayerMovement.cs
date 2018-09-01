using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public Text countText;
    public Text winText;

    //This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    private int count;

    void Start ()
    {
        count = 0;
        SetCountText();
        winText.text = "";


    }
    // Update is called once per frame
    // We marked it Fixed Update because Unity likes it with physics.
    void FixedUpdate () {
        //Add a forward force (currently disabled with //)
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 1)
        {
            winText.text = "You Win!!!!";
        }
    }
}
