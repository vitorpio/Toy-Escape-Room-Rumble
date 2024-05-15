using UnityEngine;

public static class Recoil
{

    public static void ApplyRecoil(GameObject takeRecoil, GameObject applyRecoil, float recoilForce)
    {
        Transform transform1 = takeRecoil.GetComponent<Transform>();
        Transform transform2 = applyRecoil.GetComponent<Transform>();
        Rigidbody rb = takeRecoil.GetComponent<Rigidbody>();

        Vector3 vectorForce = new Vector3(transform1.position.x - transform2.position.x, 0, transform1.position.z - transform2.position.z) * recoilForce;
        rb.AddForce(vectorForce, ForceMode.Impulse);
    }
}