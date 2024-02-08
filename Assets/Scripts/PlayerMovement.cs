using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject floor;
    public Material currentFloorMaterial;
    public Material pastFloorMaterial;
    float horizontalMovement;
    public float speed = 10.0f;
    bool isCurrentTimeLine = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        if (horizontalMovement > 0)
            transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalMovement);
        else
            Debug.Log("Cannot go back!");

        TimeSwitch();
    }

    /*void TimeSwitch()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("")
            isCurrentTimeLine = !isCurrentTimeLine;
            if(isCurrentTimeLine == true)
            {
                floor.GetComponent<SpriteRenderer>().material = currentFloorMaterial;
            }
            else
            {
                floor.GetComponent<SpriteRenderer>().material = pastFloorMaterial;
            }

        }
    }*/
}
