using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Skill
    {

        public string Skillname;
        public bool isTrained;

        public Skill(string newSkillName, bool newIsTrained)
        {
            Skillname = newSkillName;
            isTrained = newIsTrained;
        }

    }


