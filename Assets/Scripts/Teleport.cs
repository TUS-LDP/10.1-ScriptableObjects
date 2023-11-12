using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private List<Transform> teleportPoints;
    private NonStarterAssetsInputs _inputs;
    private CharacterController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _inputs = FindFirstObjectByType<NonStarterAssetsInputs>();
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputs.teleport)
        {
            DoTeleport();
            _inputs.teleport = false;
        }

    }

    private void DoTeleport()
    {
        _controller.enabled = false;

        // Pick a randon metween 0 and 3
        int randomIndexOfTeleportPoint = Random.Range(0, 4);

        transform.position = teleportPoints[randomIndexOfTeleportPoint].position;

        Debug.Log($"... teleporting ... {teleportPoints[randomIndexOfTeleportPoint].position} at index {randomIndexOfTeleportPoint}");

        _controller.enabled = true;

    }
}
