using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start the Game!");
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Playing the Game!");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Flap");
            playerRigidBody.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }
}