using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour{


    public GameObject Barrel;
    public LaserSiteControll lzrSight;
    public float speed;
    public float angle;

    public UFOController myUFO;
    public GameObject projectile;


    // Start is called before the first frame update
    void Start(){
        myUFO = GetComponent<UFOController>();
    }

    // Update is called once per frame
    void Update(){
        ShootProjectile();
    }

    public void ShootProjectile()
    {
        Vector3 dir = Input.mousePosition -  Camera.main.WorldToScreenPoint(transform.position);
       // Vector3 dir = Input.mousePosition;
        angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        dir = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir.z = 0f;
        //lzrSight.SetEnd(dir);
        lzrSight.SetEnd(dir);

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Z))
        {
            lzrSight.ToggleLaser();
        }

        if (Input.GetMouseButtonDown(0))
        {
            dir= Input.mousePosition -Camera.main.WorldToScreenPoint(transform.position);
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

            Barrel.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Instantiate(projectile, transform.position, Barrel.transform.rotation);
        }
    }
}