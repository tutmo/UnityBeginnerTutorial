using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start the Game!");

        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Playing the Game!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Flap!");

            playerRigidbody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}
