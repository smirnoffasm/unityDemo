using UnityEngine;

namespace Assets
{
    public class PlayerController : MonoBehaviour
    {
        public float MaxHeel = 20;
        public float HeelSpeed = 20;
        public GameObject Camera;

        public GameObject shot;
        public Transform shotSpawn;
        public float fireRate;

        private float nextFire = 0.0f;

        private float _curHeel;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                GameObject.Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
                //GetComponent<AudioSource>().Play();
            }
            if (!(Input.GetKey("d") && Input.GetKey("a")))
                if (Input.GetKey("d"))
                {
                    if (_curHeel > -MaxHeel)
                    {
                        var heel = HeelSpeed * Time.deltaTime;
                        _curHeel -= heel;
                        transform.Rotate(0, 0, -heel);
                    }
                }
                else if (Input.GetKey("a"))
                {
                    if (_curHeel < MaxHeel)
                    {
                        var heel = HeelSpeed * Time.deltaTime;
                        _curHeel += heel;
                        transform.Rotate(0, 0, +heel);
                    }
                }
                else
                {
                    var heel = HeelSpeed * Time.deltaTime;
                    if (heel < Mathf.Abs(_curHeel))
                    {
                        if (_curHeel < 0)
                        {
                            _curHeel += heel;
                            transform.Rotate(0, 0, +heel);
                        }
                        else
                        {
                            _curHeel -= heel;
                            transform.Rotate(0, 0, -heel);
                        }
                    }
                }
        }
    }
}