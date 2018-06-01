using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level {

    private int id;
    private int level;
    private Experience experience;

    public Level(int id, int level, Experience experience) {
        this.id = id;
        this.level = level;
        this.experience = experience;
    }

    public int getId() {
        return this.id;
    }

    public int getLevel() {
        return this.level;
    }

    public Experience getExperience() {
        return this.experience;
    }

    public void LevelUp() {
        this.level += 1;
        this.experience.clear(this.level);

        (new LevelUpEvent(this)).emit();
    }

    //====================================================//
    //                    Experience                      //
    //====================================================//

    public double getExperienceAmount() {
        return this.experience.getAmount();
    }

    public double getNextLevelAmount() {
        return this.experience.getNextLevelAmount();
    }

    public void addExperience(int xp) {
        this.experience.add(xp);

        (new ExperienceAddEvent(this.experience)).emit();
    }

    public bool LevelUpAvaliable() {
        return this.experience.LevelUpAvaliable();
    }
}
