using UnityEngine;

public class FireBallAttack : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);



        }
    }















}
