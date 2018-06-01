using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRepository {

    public Level findById(int id) {
        int level = PlayerPrefs.GetInt("level", 0);

        ExperienceRepository experienceRepository = new ExperienceRepository();
        Experience experience = experienceRepository.findById(id, level);

        Level levelInstance = new Level(id, level, experience);
        return levelInstance;
    }

    public void Update(Level level) {
        PlayerPrefs.SetInt("level", level.getLevel());

        ExperienceRepository experienceRepository = new ExperienceRepository();
        experienceRepository.Update(level.getExperience());
    }

}
