using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public System.Action destroyed;
    //An Action delegate is put simply an encapsulated method that returns no value, or a void encapsulated method.

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.destroyed.Invoke(); //other scripts can register event
        Destroy(this.gameObject); //if laser hits something,destroy it
    }
}
