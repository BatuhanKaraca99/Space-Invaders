using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }
    }
}
