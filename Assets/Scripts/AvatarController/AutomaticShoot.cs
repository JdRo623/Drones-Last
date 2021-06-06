using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShoot : MonoBehaviour
{
    public bool seeingEnemies;
    public bool seeingGround;

    public LayerMask Enemies;
    public LayerMask Ground;

    Ray ray;
    RaycastHit hit;

    private bool isLookingAnEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    public bool GetIsLookingAnEnemy() {
        return seeingEnemies;
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(transform.position, transform.forward);
        seeingEnemies = Physics.Raycast(ray, out hit, 100, Enemies);
        seeingGround = Physics.Raycast(ray, out hit, 100, Ground);

        if (seeingEnemies)
        {
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
        else if (seeingGround)
        {
            Debug.DrawLine(ray.origin, hit.point, Color.cyan);

        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 200, Color.green);

        }
    }
}
