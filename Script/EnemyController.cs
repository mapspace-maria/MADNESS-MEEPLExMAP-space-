using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform player;

    [SerializeField]
    public float moveSpeed;
    private Rigidbody rb;
    private Vector3 movement;
    private bool canMove;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(StartMovingAfterDelay(5f));
    }

    void Update()
    {
        if (canMove)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            movement = direction;
        }
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            MoveCharacter(movement);
        }
    }

    void MoveCharacter(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the Game Over screen (scene number 2)
            SceneManager.LoadScene(2);
        }
    }

    IEnumerator StartMovingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        canMove = true;
    }
}







