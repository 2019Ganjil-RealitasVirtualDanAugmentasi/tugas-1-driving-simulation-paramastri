using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COba : MonoBehaviour
{
    Rigidbody rb;
    float xAxis = 0;
    float yAxis = 0;
    [SerializeField] float kecepatan_mobil = 0;
    [SerializeField] float kecepatan_belok = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        yAxis = Input.GetAxis("Vertical"); // mendapatkan input vertical. atas 1, bawah -1
        xAxis = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * kecepatan_belok * rb.velocity.magnitude * xAxis * yAxis);//nyimpen rotasi obj skrg. bisa di + / - (kalo diem 0)
        rb.velocity = transform.forward * kecepatan_mobil * yAxis; // ngikutin obj 
		
    }

    void OnTriggerEnter(Collider other)
    {
        print("lel");
        if (other.CompareTag("PowerUp"))
        {
            other.gameObject.SetActive(false);
            kecepatan_mobil *= 3;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(3f);
        kecepatan_mobil /= 3;
    }
}
