using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float bulletSpeed = 10f;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject bullet = Instantiate(bulletPrefab,shootPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity += new Vector2(transform.localScale.x, 0) * bulletSpeed;
        }
    }
}
