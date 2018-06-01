using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience {

    private class ExperienceCalculation {

        private static double multiplier = 1.5;

        private static double[] targets;

        private ExperienceCalculation() { }

        public static double getTargetByLevel(int level) {
            if(ExperienceCalculation.targets == null) {
                ExperienceCalculation.targets = new double[0];
            }
            if (ExperienceCalculation.targets.Length > level) {
                return ExperienceCalculation.targets[level];
            }
            double[] targets = new double[level+1];
            for (int i = 0; i < ExperienceCalculation.targets.Length; i++) {
                targets[i] = ExperienceCalculation.targets[i];
            }
            for (int i = (ExperienceCalculation.targets.Length); i <= level; i++) {
                if (i == 0){
                    targets[i] = 100;
                    continue;
                }
                targets[i] = Math.Round(targets[i - 1] + (i * 100 * ExperienceCalculation.multiplier));
            }
            ExperienceCalculation.targets = targets;
            return targets[level];
        }

    }

    private int id;
	private double amount;
    private double nextLevelAmount;

    public Experience(int id, double amount, int level) {
        this.id = id;
        this.amount = amount;
        this.CalculateNextLevelAmount(level);
    }

    public int getId() {
        return this.id;
    }

    private void CalculateNextLevelAmount(int level) {
        this.nextLevelAmount = ExperienceCalculation.getTargetByLevel(level);
    }

    public double getNextLevelAmount() {
        return this.nextLevelAmount;
    }

    public double getAmount() {
        return this.amount;
    }

    public void add(double xp) {
        this.amount += xp;
    }

    public bool LevelUpAvaliable() {
        return this.amount >= this.nextLevelAmount;
    }

    public void clear(int level) {
        double rest = this.amount - this.nextLevelAmount;
        this.amount = rest;
        this.CalculateNextLevelAmount(level);
    }

}