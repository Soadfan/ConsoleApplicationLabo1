using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pTest = new Pupil("johnsnow", 25, 1);
            Activity act1 = new Activity("test1", true);
            Activity act2 = new Activity("test2", false);
            Activity act3 = new Activity("test3", false);

            pTest.AddActivity(act1);
            pTest.AddEvaluation("test1");
            pTest.AddActivity(act2);
            pTest.AddEvaluation("test2");
            pTest.AddActivity(act3);
            pTest.AddEvaluation("test3");

            pTest.AddEvaluation(evaluation: 'T', title: "test1");


            List<Pupil> listPupilsDuplicated = new List<Pupil>()
         {
            new Pupil ("Player1", 12, 5),
            new Pupil ("Player1", 5, 1),
            new Pupil ("Player1", 5, 6),
            new Pupil ("Player4", 7, 1),
            new Pupil ("Player5", 7, 2)
         };
            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            if (listPupilsNoDuplicated != null)
            {
                foreach (var nodup in listPupilsNoDuplicated)
                {
                    System.Console.Write(nodup);
                    System.Console.Write("\n");
                }
            }


           /* List<Pupil> lstPupil = new List<Pupil>()
         {
            new Pupil ("Player1", 12, 5),
            new Pupil ("Player2", 5, 1),
            new Pupil ("Player3", 7, 1),
            new Pupil ("Player4", 7, 1),
            new Pupil ("Player5", 7, 2)
         };

            List<Person> lstPerson = new List<Person>()
         {
            new Person ("Pers1", 14 ),
            new Person ("Pers2", 15 ),
            new Person ("Pers3", 16 ),
            new Person ("Pers4", 17 ),
            new Person ("Pers5", 18)
         };

            var listFusion = lstPerson.Union(lstPupil);

            if (listFusion != null)
            {
                foreach (var fus in listFusion)
                {
                    System.Console.Write(fus);
                    System.Console.Write("\n");
                }
            }
           */

            /*
            var pupilGrade1Plus6 = lstPupil.Where(pupil=> (pupil.Grade == 1 && pupil.Age > 6));
                
            => commentaires =>     from Pupil in lstPupil
                                   where Pupil.Grade == 1 && Pupil.Age > 6
                                   select Pupil;
            */

           // System.Console.Write(pTest); 
            
            /*if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    System.Console.Write("\n");
                }
            }*/

            System.Console.Read();
        }
    }
}
