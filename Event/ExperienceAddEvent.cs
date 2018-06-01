using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceAddEvent : Event {

    private Experience experience;

    public ExperienceAddEvent(Experience experience) : base("experience_add") {
        this.experience = experience;
    }

    public Experience getExperience() {
        return this.experience;
    }

}
