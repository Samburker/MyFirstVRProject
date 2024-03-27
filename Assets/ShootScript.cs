using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform barrel;
    public float bulletSpeed = 10f; // Define bullet speed here

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, barrel.position, barrel.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = barrel.forward * bulletSpeed;
    }
}
