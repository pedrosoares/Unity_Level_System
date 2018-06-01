using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoGuiController : MonoBehaviour {

    public LevelManager player;

    public Text level;
    public Text experience;
    public Text nextLevel;

    void Update() {
        Level level = this.player.getLevel();
        this.level.text      = "Level:      " + level.getLevel() + "";
        this.experience.text = "Experience: " + level.getExperienceAmount() + "";
        this.nextLevel.text  = "Next Level: " + level.getNextLevelAmount() + "";
    }

    public void AddLevel() {
        this.player.addExperience(100);
    }

    public void clear() {
        PlayerPrefs.DeleteAll();
    }

}
