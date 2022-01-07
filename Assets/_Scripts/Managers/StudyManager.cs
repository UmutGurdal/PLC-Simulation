using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyManager : MonoBehaviour
{

    public GameObject
        StudyOne,
        StudyTwo,
        StudyThree;

    private GameObject activeStudy;

    public void ChangeStudy(GameObject study)
    {
        activeStudy?.gameObject.SetActive(false);
        study.gameObject.SetActive(true);
        activeStudy = study;
    }
}
