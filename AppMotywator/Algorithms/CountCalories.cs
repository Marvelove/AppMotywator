using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMotywator.Algorithms
{
    public class CountCalories
    {
        private int age;
        private int height;     // cm
        private int weight;     //kg
        private int gender;
        private int lifestyle;
        private int physique;
        private int target;

        enum Gender
        {
            woman,
            man
        };

        enum Lifestyle
        {
            lackofactivity,
            sittingwork,
            worknotphysical,
            lightworkphysical,
            workphysical,
            heavyphysical
        };

        enum Physique
        {
            endomorfik,
            mezomorfik,
            ektomorfik
        }


        enum Aim
        {
            buildingmass,
            weightreduction
        }

    }
}