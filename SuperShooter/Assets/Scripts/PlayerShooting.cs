using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject shootPoint;
    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] private float spawnOffset = 0.2f; // how far in front of the shootPoint to spawn
    [SerializeField] private float lifeTime = 5f;

    private int lastShotFrame = -1000;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Optional legacy input support; guarded to avoid duplicate shots with OnFire
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (prefab == null)
        {
            Debug.LogWarning("PlayerShooting: Prefab not assigned.");
            return;
        }

        // Prevent double-fire in the same frame if both Update and OnFire are active
        if (lastShotFrame == Time.frameCount) return;

        // Use shootPoint if provided; otherwise fall back to this transform
        Transform origin = shootPoint != null ? shootPoint.transform : transform;

        Vector3 spawnPos = origin.position + origin.forward * spawnOffset;
        Quaternion spawnRot = origin.rotation;

        GameObject clone = Instantiate(prefab, spawnPos, spawnRot);

        // Propel the bullet straight forward away from the player
        if (clone.TryGetComponent<Rigidbody>(out var rb))
        {
            rb.velocity = origin.forward * bulletSpeed;
        }
        else if (clone.TryGetComponent<ForwardMovement>(out var fm))
        {
            fm.speed = bulletSpeed;
        }

        if (lifeTime > 0f)
        {
            Destroy(clone, lifeTime);
        }

        lastShotFrame = Time.frameCount;
    }
}
