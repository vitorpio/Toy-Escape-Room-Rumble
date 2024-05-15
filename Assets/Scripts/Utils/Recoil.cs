using UnityEngine;

public static class Recoil
{

    public static void ApplyRecoil(GameObject takeRecoil, GameObject applyRecoil, float recoilForce)
    {
        Transform transform1 = takeRecoil.GetComponent<Transform>();
        Transform transform2 = applyRecoil.GetComponent<Transform>();
        Rigidbody rb = takeRecoil.GetComponent<Rigidbody2D>();

        Vector3 vectorForce = (transform1.position - transform2.position) * recoilForce;
        rb.AddForce(vectorForce, ForceMode.Impulse);
    }
}