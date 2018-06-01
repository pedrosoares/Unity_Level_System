using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private LevelRepository levelRepository;

    private Level level;

	void Start () {
        int id = 1; /** TODO Create a Const Class to Access the Player ID */
        this.levelRepository = new LevelRepository();
        this.level = this.levelRepository.findById(id);
    }
	
    public void addExperience(int xp) {
        this.level.addExperience(xp);
        if (this.level.LevelUpAvaliable()) {
            this.level.LevelUp();
        }

        levelRepository.Update(this.level);
    }

    public Level getLevel() {
        return this.level;
    }

}
