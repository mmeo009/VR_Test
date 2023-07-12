using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRTransform
{
    [SerializeField] public Transform vrTransform;
    [SerializeField] public Transform target;
    [SerializeField] public Vector3 positionOffset;
    [SerializeField] public Vector3 rotationOffset;
    public void Follow()
    {
        target.position = vrTransform.position + positionOffset;
        target.rotation = vrTransform.rotation * Quaternion.Euler(rotationOffset);
    }
}
public class VRController : MonoBehaviour
{
    [SerializeField] private VRTransform leftHand;
    [SerializeField] private VRTransform rightHand;
    [SerializeField] private VRTransform head;

    [SerializeField] private Transform bodyTransform;
    [SerializeField] private Transform ikHead;
    [SerializeField] private Vector3 headbodyOffset;
    // [SerializeField] private VRTransform head;

    private void Update()
    {
        leftHand.Follow();
        rightHand.Follow();
       // head.Follow();
    }

    private void FollowBody()
    {
        bodyTransform.position = ikHead.position + headbodyOffset;
    }


}
