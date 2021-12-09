using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    PlayerController playerController;
    private void Awake()
    {
        playerController = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(false);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == playerController.gameObject)
        {
            return;
        }
        playerController.setGroundedState(true);
    }
}
