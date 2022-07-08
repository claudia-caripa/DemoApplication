using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{

    //Define an Interface, which is a contract for the Tutorial class
    public interface ITutorialInterface
    {
        void SetTutorial(int pID, String pName);
        String GetTutorialName();
        int GetTutorialID();
        //public int GetTutorialCount();
    }

    public class Tutorial : ITutorialInterface
    {
        protected int TutorialID;
        protected string TutorialName;

        //Constructor Class
        /*public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }*/

        public void SetTutorial (int pID, String pName) { 
            TutorialID = pID; 
            TutorialName = pName; 
        }

        //Polymorphism: a method with the same name, but it accepts different parameters.
        public void SetTutorial(String pName) { 
            TutorialName = pName;
        }

        public String GetTutorialName()
        {
            return TutorialName;
        }

        public int GetTutorialID()
        {
            return TutorialID;
        }

    }

    //Child Class that inherits from Tutorial class
    public class ChildTutorial : Tutorial
    {
        public void RenameTutorial (String pNewName)
        {
            TutorialName = pNewName;
        }
    }
}
