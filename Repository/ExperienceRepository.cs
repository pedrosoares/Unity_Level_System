using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceRepository {

    public Experience findById(int id, int level) {
        Experience experience = new Experience(id, double.Parse(PlayerPrefs.GetString("experience", "0")), level);
        return experience;
    }

    public void Update(Experience experience) {
        PlayerPrefs.SetString("experience", experience.getAmount() + "");
    }

}
