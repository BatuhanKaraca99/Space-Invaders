using UnityEngine;

public class MysteryShip : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            this.gameObject.SetActive(false);
        }
    }
}
