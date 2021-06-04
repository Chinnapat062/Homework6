using System;

namespace การบ้านครั้งที่_6
{
    class Program
    {
        static void Main()
        {
            //Menu
            int score = 0;    
            Console.WriteLine("Score :{0}",score);
            Console.WriteLine("Difficulty :{Easy}");
            pageeasy();
        }
        static void Maineasycase()
        {
            int score = 0;
            Console.WriteLine("Score :{0}", score);
            Console.WriteLine("Difficulty :{Easy}");
            pageeasy();
        }
        static void MainNormalcase()
        {
            int score = 0;
            Console.WriteLine("Score :{0}", score);
            Console.WriteLine("Difficulty :{Normal}");
            pagenormal();
        }
        static void MainHardcase()
        {
            int score = 0;
            Console.WriteLine("Score :{0}", score);
            Console.WriteLine("Difficulty :{Hard}");
            pagehard();
        }

        
       

        //เมนูโหมดง่าย
        static void pageeasy()
        {
            Console.WriteLine("[0] Playgame");
            Console.WriteLine("[1] Setting");
            Console.WriteLine("[2] Exit");

            int selectpage = int.Parse(Console.ReadLine());
            switch (selectpage)
            {
                case 0:
                    playgameeasy();
                    break;
                case 1:
                    setting();
                    break;
                case 2:
                    break;
            }
        }

        //เมนูโหมดปกติ
        static void pagenormal()
        {
            Console.WriteLine("[0] Playgame");
            Console.WriteLine("[1] Setting");
            Console.WriteLine("[2] Exit");

            int selectpage = int.Parse(Console.ReadLine());
            switch (selectpage)
            {
                case 0:
                    playgamenormal();
                    break;
                case 1:
                    setting();
                    break;
                case 2:
                    break;
            }
        }
        //เมนูโหมดยาก
        static void pagehard()
        {
            Console.WriteLine("[0] Playgame");
            Console.WriteLine("[1] Setting");
            Console.WriteLine("[2] Exit");

            int selectpage = int.Parse(Console.ReadLine());
            switch (selectpage)
            {
                case 0:
                    playgamehard();
                    break;
                case 1:
                    setting();
                    break;
                case 2:
                    break;
            }
        }



        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }


        
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }

            return randomProblems;
        }

        
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }
       
        
        
        //เลือกระดับความยาก(setting page)
        struct Settingpage
        {
            public Difficulty selectDif;
        }
        static void setting()
        {
            Console.WriteLine("Select your difficult");
            Settingpage selectdifficulty;
            int selectdif = int.Parse(Console.ReadLine());
            selectdifficulty.selectDif = (Difficulty)selectdif;

            if (selectdif != 0 && selectdif != 1 && selectdif != 2)
            {
                Console.WriteLine("please input 0-2 ");
                setting();
            }
            else if (selectdif == 0)
            {
                Maineasycase();
            }
            else if (selectdif == 1)
            {
                MainNormalcase();
            }
            else if (selectdif == 2)
            {
                MainHardcase();
            }

        }
        
        

        //เล่นเกมโหมดง่าย
        static void playgameeasy()
        {
            Double QC = 0;
            int Play;
            int selecDif = 0;
            int Ans;
            Double Lastestscore=0;
            Play = 2 * selecDif + 3;
            if (selecDif == 0)
            {
                long Starttime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Starttime);

                Console.WriteLine("Easy");
                for (int i = 1; i <= Play; i++)

                {

                    Problem[] GenerateRandomProblemsArray;
                    GenerateRandomProblemsArray = GenerateRandomProblems(Play);
                    Console.WriteLine(GenerateRandomProblemsArray[0].Message);
                    Ans = int.Parse(Console.ReadLine());
                    Console.WriteLine(GenerateRandomProblemsArray[0].Answer);

                    if (Ans == GenerateRandomProblemsArray[0].Answer)
                    {
                        QC = QC + 1;
                    }


                }
                long Endtime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Endtime);
                Lastestscore = Lastestscore + ((QC / Play) * ((25 - Math.Pow(selecDif, 2)) / Math.Max(Starttime - Endtime, 25 - Math.Pow(selecDif, 2))) * (Math.Pow(2 * selecDif + 1, 2)));
                Console.WriteLine("Score is  : {0}  Difficulty : Easy", + Lastestscore);
                pageeasy();

            }
        }

        //เล่นเกมโหมดปกติ
        static void playgamenormal()
        {
            Double QC = 0;
            int Play;
            int selecDif = 1;
            int Ans;
            Double Lastestscore=0;
            Play = 2 * selecDif + 3;


             if (selecDif == 1)
            {
                long Starttime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Starttime);


                Console.WriteLine("Normal");
                for (int i = 1; i <= Play; i++)

                {


                    Problem[] GenerateRandomProblemsArray;
                    GenerateRandomProblemsArray = GenerateRandomProblems(Play);
                    Console.WriteLine(GenerateRandomProblemsArray[0].Message);
                    Ans = int.Parse(Console.ReadLine());
                    Console.WriteLine(GenerateRandomProblemsArray[0].Answer);

                    if (Ans == GenerateRandomProblemsArray[0].Answer)
                    {
                        QC = QC + 1;
                    }


                }
                long Endtime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Endtime);
                Lastestscore = Lastestscore + ((QC / Play) * ((25 - Math.Pow(selecDif, 2)) / Math.Max(Starttime - Endtime, 25 - Math.Pow(selecDif, 2))) * (Math.Pow(2 * selecDif + 1, 2)));
                Console.WriteLine("Score is  : {0}  Difficulty : Normal", +Lastestscore);
                pagenormal();
            }
        }

    // เล่นเกมโหมดยาก
        static void playgamehard()
        {
            Double QC = 0;
            int Play;
            int selecDif = 2;
            int Ans;
            Double Lastestscore=0;
            Play = 2 * selecDif + 3;


              if (selecDif == 2)
            {
                long Starttime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Starttime);

                Console.WriteLine("Hard");
                for (int i = 1; i <= Play; i++)

                {


                    Problem[] GenerateRandomProblemsArray;
                    GenerateRandomProblemsArray = GenerateRandomProblems(Play);
                    Console.WriteLine(GenerateRandomProblemsArray[0].Message);
                    Ans = int.Parse(Console.ReadLine());
                    Console.WriteLine(GenerateRandomProblemsArray[0].Answer);

                    if (Ans == GenerateRandomProblemsArray[0].Answer)
                    {
                        QC = QC + 1;
                    }


                }
                long Endtime = DateTimeOffset.Now.ToUnixTimeSeconds();
                Console.WriteLine(Endtime);
                Lastestscore = Lastestscore + ((QC / Play) * ((25 - Math.Pow(selecDif, 2)) / Math.Max(Starttime - Endtime, 25 - Math.Pow(selecDif, 2))) * (Math.Pow(2 * selecDif + 1, 2)));
                Console.WriteLine("Score is  : {0}  Difficulty : Hard", +Lastestscore);
                pagehard();
            }
        }





    }
}
