using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lesson = Console.ReadLine()
             .Split(", ")        
             .ToList();

            string Comand = Console.ReadLine();

            while (Comand!= "course start")
            {
                string[] comandArgs = Comand.Split(":").ToArray();

                string FirstComand = comandArgs[0];
                string lessonTitle = comandArgs[1];

                if (FirstComand=="Add")
                {
                    if (!lesson.Contains(lessonTitle))
                    {
                        lesson.Add(lessonTitle);
                    }
                }
                else if (FirstComand == "Insert")
                {
                    int Index = int.Parse(comandArgs[2]);

                    if (!lesson.Contains(lessonTitle))
                    {
                        lesson.Insert(Index, lessonTitle);
                    }

                }
                else if (FirstComand == "Remove")
                {
                    if (lesson.Contains(lessonTitle))
                    {
                        lesson.Remove( lessonTitle);
                    }
                }
                else if (FirstComand == "Swap")
                {
                    string SecondLesonTitle = comandArgs[2];

                    int indexOfFirstLesson = lesson.IndexOf(lessonTitle);
                    int indexOFSecondLesson = lesson.IndexOf(SecondLesonTitle);

                    if (indexOfFirstLesson!=-1&indexOFSecondLesson!=-1)
                    {
                        lesson[indexOfFirstLesson] = SecondLesonTitle;
                        lesson[indexOFSecondLesson] = lessonTitle;

                        string firstLessonExersise = $"{lessonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson<lesson.Count&&lesson[indexOfFirstExercise]==firstLessonExersise)
                        {
                            lesson.RemoveAt(indexOfFirstExercise);

                            indexOfFirstExercise = lesson.IndexOf(lessonTitle);
                            lesson.Insert(indexOfFirstExercise, firstLessonExersise);
                        }

                        string secondLessonExersice = $"{SecondLesonTitle}-Exercise";
                        int indexOfSecondExersise = indexOFSecondLesson+1;

                        if (indexOfSecondExersise<lesson.Count&&
                            lesson[indexOfSecondExersise]==secondLessonExersice)
                        {
                            lesson.RemoveAt(indexOFSecondLesson+1);

                            indexOFSecondLesson = lesson.IndexOf(SecondLesonTitle);

                            lesson.Insert(indexOFSecondLesson + 1, secondLessonExersice);
                        }
                    }

                }
                else if (FirstComand == "Exercise")
                {
                    int index = lesson.IndexOf(lessonTitle);
                    string exersize = $"{lessonTitle}-Exercise";

                    bool isThereAreLesson = lesson.Contains(lessonTitle);
                    bool isThereAreExersise = lesson.Contains(exersize);
                    if (isThereAreLesson&&!isThereAreExersise)
                    {
                        lesson.Insert(index + 1, exersize);
                    }
                    else if (!isThereAreLesson)
                    {
                        lesson.Add(lessonTitle);
                        lesson.Add(exersize);
                    }
                   
                }

                Comand = Console.ReadLine();
            }

            for (int i = 0; i < lesson.Count; i++)
            {
                Console.WriteLine($" {i+1}.{lesson[i]}");
            }
        }
    }
}
