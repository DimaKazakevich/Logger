using System;

namespace Lab7
{
    class Registration
    {
        private readonly ILogger _logger;

        public Registration(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessRegistration()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            CheckAge(age);

            Console.WriteLine("Enter your sex(M or F)");
            char sex = char.Parse(Console.ReadLine());
            CheckSex(sex);

            Console.WriteLine("Enter your name");

            CheckName(Console.ReadLine());
        }

        public void CheckAge(int age)
        {
            if (age < 18 && age > 0)
            {
                throw new AgeException("Registration of users under the age of 18 is not possible");
            }

            if (age < 0)
            {
                throw new AgeException("Age entered incorrectly");
            }

            _logger.Log($"Age {age} accepted", MessageType.Info);
        }

        public void CheckName(string name)
        {
            foreach (char symbol in name)
            {
                if (char.IsNumber(symbol))
                {
                    throw new IntException("Name entered incorrectly");
                }
            }

            _logger.Log($"Name {name} accepted", MessageType.Info);
        }

        public void CheckSex(char sex)
        {
            if (char.IsDigit(sex))
            {
                throw new IntException("Sex must not contain numbers");
            }

            if (sex == 'M' || sex == 'F')
            {
                _logger.Log($"Sex {sex} accepted", MessageType.Info);
            }
            else
            {
                throw new CharException("Sex entered incorrectly");
            }
        }
    }
}
