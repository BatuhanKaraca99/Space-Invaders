using UnityEngine;

public class Player : MonoBehaviour
{
    public Projectile laserPrefab;
    public float speed = 5.0f;
    private bool _laserActive;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) //laser -> Mouse button or space
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (!_laserActive) //if laser is not active
        {
            Projectile projectile = Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += LaserDestroyed; //delegate invoke
            _laserActive = true;
        }
    }

    private void LaserDestroyed()
    {
        _laserActive = false; //allow us to shoot again
    }
}
