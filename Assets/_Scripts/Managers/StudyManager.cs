using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyManager : MonoBehaviour
{

    public Study
        StudyOne,
        StudyTwo,
        StudyThree;

    private Study activeStudy;

    public void ChangeStudy(Study study)
    {
        activeStudy?.gameObject.SetActive(false);
        study.gameObject.SetActive(true);
        activeStudy = study;
    }
}
