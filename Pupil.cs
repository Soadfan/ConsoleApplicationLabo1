using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        private List<Activity> lstActivities;
 

        public int Grade { get; set; }
        public List<Activity> LstActivities { get; set; }
        public char[] pupilEvaluations { get; set; }

        public Pupil(String name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            pupilEvaluations = new char[Parameter.MAXACTI];
        }

        public Pupil(String name, int age)
            : this(name, age, 1)
        {

        }

        private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();

        public Dictionary<String, char> PupilActivities
        {
            get { return pupilActivities; }
            set { pupilActivities = value; }
        }

        public void AddActivity(String activityTitle)
        {
            PupilActivities.Add(activityTitle, '0');
        }

        public void AddEvaluation(String title = null, char evaluation = (char)Parameter.enumEval.S)
        {
            if (title != null) PupilActivities[title] = evaluation;
        }

        private string PrintCourses(string ch)
        {
            int i;
            for (i = 0; i < PupilActivities.Count(); i++)
                ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value;
            return ch;
        }

       /* private string Header()
        {
            return base.ToString() + ((PupilActivities.Count() != 0) ? " a choisi ...\n" : " n’a pas encore choisi d’activité\n");
        }*/

        public void AddActivity(Activity act)
        {
            LstActivities.Add(act);
        }

        public override string ToString()
        {

            string ch = Header();

            ch = PrintActivities(ch);
            return ch;
        }

        private string PrintActivities(string ch)
        {
            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += LstActivities[i];
                ch += "\n";

            }
            return ch;
        }

        private string Header()
        {
            return base.ToString() +
                         ((LstActivities.Count() != 0) ? "a choisi ..." : "n’a pas encore choisi d’activité");
        }

        /*public void AddEvaluation(String title = null, char evaluation = (char)Parameter.enumEval.S)
        {
            int i = 0;
            if (title != null)
            {
                if (LstActivities.Count() > 0)
                {
                    foreach (Activity activity in LstActivities)
                    {
                        if (activity.Title.Equals(title)) break;
                        i++;
                    }
                    pupilEvaluations[i] = evaluation;
                }
                else { System.Console.Write("Erreur: Aucune activitée !"); }
            }

        }*/

        

    }
}
